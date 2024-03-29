﻿using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;
using ABB_BF.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ABB_BF.DAL.Repositories
{
    public class PracticeRepository : IPracticeRepository
    {
        private readonly Context _context;

        public PracticeRepository(Context context)
        {
            _context = context;
        }

        public async Task<int> AddPractice(Practice practice)
        {
            await _context.Practice.AddAsync(practice);
            await _context.SaveChangesAsync();

            return practice.Id;
        }

        public async Task<List<Practice>> GetAll(Filter filter)
        {
            List<Practice> practices = await _context.Practice
                .Where(c =>
                    (filter.IsChecked == null || c.IsChecked != filter.IsChecked) &&
                    (c.CreationDate >= DateOnly.FromDateTime(filter.StartInterval)) &&
                    (c.CreationDate <= DateOnly.FromDateTime(filter.FinishInterval))).ToListAsync();

            foreach (Practice practice in practices)
            {
                practice.IsChecked = true;
            }

            await _context.SaveChangesAsync();

            return practices;
        }
    }
}
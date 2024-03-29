﻿using ABB_BF.DAL.Entities;

namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface ICollegeRepository
    {
        Task AddCollege(College college);
        Task<List<College>> GetAllColleges();
        Task<College> GetCollegeByName(string name);
        Task<College> GetCollegeById(int id);
    }
}
﻿using ABB_BF.DAL.Entities;

namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface IProbationRepository
    {
        Task<int> AddProbation(Probation probation);
    }
}
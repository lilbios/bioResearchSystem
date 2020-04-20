﻿using bioResearchSystem.Context;
using bioResearchSystem.DAL.Repositories;
using bioResearchSystem.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace bioResearchSystem.DAL.Implementations
{
    public class ExperimentRepository:IRepositoryExperiment
    {
        private readonly BioResearchSystemDbContex dbContext;
        public ExperimentRepository(BioResearchSystemDbContex _dbContext)
        {
            dbContext = _dbContext;
        }

        public Task Create(Experiment value)
        {
            throw new NotImplementedException();
        }

        public Task<Experiment> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Experiment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Experiment value)
        {
            throw new NotImplementedException();
        }

        public Task Update(Experiment value)
        {
            throw new NotImplementedException();
        }
    }
}
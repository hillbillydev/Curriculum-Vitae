﻿using System.Collections.Generic;
using Contracts;
using DataLayer.Logic.Database.UnitOfWork;
using Mappers;

namespace Business_Logic.Database
{
    public class CompanyHandler
    {
        private UnitOfWork _uow;

        public List<Company> Get()
        {
            return _uow.CompanyRepository.Get().ToContracts();
        }

        public Company Get(int id)
        {
            return _uow.CompanyRepository.Get(id).ToContract();
        }

        public void Post(Company company)
        {
            _uow.CompanyRepository.CreateOrUpdate(company.ToDatabaseEntitie());
        }

        public void Delete(int id)
        {
            _uow.CompanyRepository.Delete(id);
        }
    }
}

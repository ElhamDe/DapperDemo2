﻿using DapperDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo2.Repository
{
    public interface IEmployeeRepository
    {
        Employee Find(int id);
        List<Employee> GetAll();

        Employee Add(Employee employee);
        Task<Employee> AddAsync(Employee employee);
        Employee Update(Employee employee);
        void Remove(int id);
    }
}

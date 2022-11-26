﻿using Dapper;
using FinalProject.Core.Common;
using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject.Infra.Repository
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IDbContext dbContext;
        public TestimonialRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Testimonial> GetAlltestimonial()
        {
            IEnumerable<Testimonial> users = dbContext.Connection.Query<Testimonial>("testimonial_p.GetAlltestimonial", commandType: CommandType.StoredProcedure);
            return users.ToList();
        }

        public void CREATEtestimonial(Testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("userID_fk1", testimonial.UseridFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("paragraph1", testimonial.Paragraph, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("isaccept1", testimonial.Isaccept, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("rate1", testimonial.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("testimonial_p.CREATEtestimonial", p, commandType: CommandType.StoredProcedure);

        }

        public void UPDATEtestimonial(int id, Testimonial testimonial)
        {

            var p = new DynamicParameters();
            
            p.Add("ID", testimonial.Testimonialid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("userID_fk1", testimonial.UseridFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("paragraph1", testimonial.Paragraph, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("isaccept1", testimonial.Isaccept, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("rate1", testimonial.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("testimonial_p.UPDATEtestimonial", p, commandType: CommandType.StoredProcedure);
        }

        public Testimonial GettestimonialtById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Testimonial> users = dbContext.Connection.Query<Testimonial>("testimonial_p.GettestimonialtById", p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();
        }


        public void Deletetestimonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("testimonial_p.Deletetestimonial", p, commandType: CommandType.StoredProcedure);
        }


    }
}
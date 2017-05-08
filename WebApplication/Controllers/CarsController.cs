using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        // Declares the DBContext class
        private CarsContext dataContext;
        // The instance of DBContext is passed via dependency injection
        public CarsController(CarsContext context)
        {
            this.dataContext = context;
        }
        // GET
        [HttpGet]
        public IEnumerable<Cars> Index()
        {
            var objResult = this.dataContext.Cars.ToList();
            return objResult;
        }

        // POST
        [HttpPost]
        public dynamic Create([FromBody]Cars car)
        {
            bool isduplicate = dataContext.Cars.Any(m => m.CarModel == car.CarModel);
            if(isduplicate == false)
            {
                
                this.dataContext.Add(car);
                this.dataContext.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
            
        }

        // DELETE
        /*[HttpDelete("{id}")]
        public dynamic Delete(int id)
        {
            Cars car = dataContext.Cars.SingleOrDefault(m => m.Id == id);
            try{
                this.dataContext.Cars.Remove(car);
                this.dataContext.SaveChanges();
            }catch(Exception e){
                return e.ToString();
            }

            dynamic objresponse = new { data = car.Id };
            return objresponse;
        }
        */

        // DELETE
        [HttpDelete("{id}")]
        public String Delete(int id)
        {
            Cars car = dataContext.Cars.SingleOrDefault(m => m.Id == id);
            if (car == null) 
            {
                return "No Data";
            }
            else
            {
                this.dataContext.Cars.Remove(car);
                this.dataContext.SaveChanges();
                return "Data Deleted";
            }
        }

        // UPDATE
        [HttpPut]
        public dynamic Update([FromBody]Cars car)
        {   
            bool updatecar = dataContext.Cars.Any(m => m.Id == car.Id);
            
            if (updatecar)
            {
                this.dataContext.Cars.Update(car);
                this.dataContext.SaveChanges();
                return updatecar+"Data Updated";
            }
            else
            {
                return "No Data";
            }
            
        }
    }
}
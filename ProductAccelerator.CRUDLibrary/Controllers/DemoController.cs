using Microsoft.AspNetCore.Mvc;
using ProductAccelerator.CRUDLibrary.Domain.Entities;
using ProductAccelerator.CRUDLibrary.Infrastructure.Repositories;

namespace ProductAccelerator.CRUDLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        //private readonly IDemoRepository _demoRepository;
        private readonly IUnitofWork unitofWork;

        public DemoController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
            //_demoRepository = new BaseRepository
            //_baseRepository = baseRepository;
        }


        [HttpGet("GetData")]
        public async Task<IActionResult> GetData()
        {
            var demo = unitofWork.Demo.GetAll();
            return Ok(demo);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(DemoEntity demoEntity)
        {
            var demo = new DemoEntity();

            demo.Name = demoEntity.Name;
            demo.Address = demoEntity.Address;

            await unitofWork.Demo.Create(demo);
            return Ok("Data Inserted Successfully");
        }

        [HttpPost("Create2")]
        public async Task<IActionResult> Create2(EmployeeEntity employeeEntity)
        {
            var emp = new EmployeeEntity();

            emp.EmployeeName = employeeEntity.EmployeeName;
            emp.EmployeeDescription = employeeEntity.EmployeeDescription;

            await unitofWork.Employee.Create(emp);
            return Ok("Data Inserted Successfully");
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(int id, DemoEntity demoEntity)
        {
            if (id == demoEntity.Id)
            {
                demoEntity.Name = demoEntity.Name;
                demoEntity.Address = demoEntity.Address;
                demoEntity.UpdatedDate = DateTime.Now;
                demoEntity.IsDeleted=false;
                await unitofWork.Demo.Update(id, demoEntity);
            }
            return Ok("Data Updated Successfully");
        }



        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(DemoEntity demoEntity)
        {
                var demo = new DemoEntity();

                demo.Id = demoEntity.Id;
                await unitofWork.Demo.Delete(demo);
                return Ok("Data Deleted Successfully");
        }

        [HttpDelete("SoftDelete")]
        public async Task<IActionResult> SoftDelete(DemoEntity demoEntity)
        {
            var demo = new DemoEntity();
            demo.Id = demoEntity.Id;
            await unitofWork.Demo.SoftDelete(demo);
            return Ok("Data Softly Deleted");
        }



    }

       
}
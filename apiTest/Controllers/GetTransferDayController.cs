using apiTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace apiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTransferDayController : ControllerBase
    {
        private readonly ItdVapcfContext _context;

        public GetTransferDayController(ItdVapcfContext context)
        {
            _context = context;
        }

        [HttpGet("get-date-transfer")]
        public async Task<IActionResult> GetDateTransfer([FromQuery] DateTime dateInput)
        {
            // Kiểm tra xem ngày đầu vào có hợp lệ hay không
            if (dateInput == default)
            {
                return BadRequest("Invalid date format");
            }

            // Định dạng chuỗi ngày tháng trước khi truyền vào câu lệnh SQL
            string formattedDateInput = dateInput.ToString("yyyy-MM-dd");

            // Thực hiện truy vấn cơ sở dữ liệu với ngày đầu vào đã được định dạng
            var transferData = await _context.Database.ExecuteSqlInterpolatedAsync($"EXEC getTransferDate {formattedDateInput}");


            // Trả về danh sách dữ liệu dưới dạng API
            return Ok(transferData);
        }
    }
}
    


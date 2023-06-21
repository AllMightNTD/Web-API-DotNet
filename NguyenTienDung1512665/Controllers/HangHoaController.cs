using Microsoft.AspNetCore.Mvc;
using NguyenTienDung1512665.Dtos.HangHoa;
using NguyenTienDung1512665.Services.Interfaces;

namespace NguyenTienDung1512665.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HangHoaController : ControllerBase
    {
        // Khai báo trường _hanghoaServices thuộc IHangHoaServices1512665De2
        private readonly IHangHoaServices1512665De2 _hangHoaServices;

        public HangHoaController(IHangHoaServices1512665De2 hangHoaServices)
        {
            _hangHoaServices = hangHoaServices;
        }

        [HttpPost]
        public ActionResult<AddHangHoaDto1512665> AddHangHoa(AddHangHoaDto1512665 input)
        {
            try
            {
                var result = _hangHoaServices.AddHangHoa(input);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<GetHangHoaDto1512665> EditHangHoaById(int id, AddHangHoaDto1512665 updateHangHoa)
        {
            try
            {
                var result = _hangHoaServices.EditHangHoaById(id, updateHangHoa);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<GetHangHoaDto1512665>> GetAllHangHoas()
        {
            try
            {
                var result = _hangHoaServices.GetAllHangHoas();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<GetHangHoaDto1512665> GetHangHoaById(int id)
        {
            try
            {
                var result = _hangHoaServices.GetHangHoaByID(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteHangHoaById(int id)
        {
            try
            {
                _hangHoaServices.DeleteHangHoaById(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("paged")]
        public ActionResult<List<GetHangHoaDto1512665>> GetAllHangHoasPaged(int pageSize, int pageIndex, HangHoaFilterDto filter)
        {
            try
            {
                var result = _hangHoaServices.GetAllHangHoasPaged(pageSize, pageIndex, filter);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

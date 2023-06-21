using NguyenTienDung1512665.DbContexts;
using NguyenTienDung1512665.Dtos.HangHoa;
using NguyenTienDung1512665.Services.Interfaces;
using NguyenTienDung1512665.Entities;
using Microsoft.EntityFrameworkCore;

namespace NguyenTienDung1512665.Services.Implements
{
    public class HangHoaServices1512665De2 : IHangHoaServices1512665De2
    {
        private readonly HangHoaContext1512665De2 _dbContext;

        public HangHoaServices1512665De2(HangHoaContext1512665De2 dbContext)
        {
            _dbContext = dbContext;
        }
        public AddHangHoaDto1512665 AddHangHoa(AddHangHoaDto1512665 input)
        {
            if (_dbContext.HangHoaContext1512665De2s.Any(b => b.TenHangHoa == input.TenHangHoa))
            {
                throw new Exception("Tên hàng hóa không được trùng.");
            }
            if (_dbContext.HangHoaContext1512665De2s.Any(b => b.MaHangHoa == input.MaHangHoa))
            {
                throw new Exception("Mã hàng hóa không được trùng.");
            }

            var newHangHoa = new HangHoa1512665De2
            {
                MaHangHoa = input.MaHangHoa,
                TenHangHoa = input.TenHangHoa,
                DonViTinh = input.DonViTinh,
                SoLuong = input.SoLuong
            };

            _dbContext.HangHoaContext1512665De2s.Add(newHangHoa);
            _dbContext.SaveChanges();

            return input;
        }


        public GetHangHoaDto1512665 EditHangHoaById(int id , AddHangHoaDto1512665 updateHangHoa)
        {
            var hangHoa = _dbContext.HangHoaContext1512665De2s.FirstOrDefault(b => b.Id == id);
            if(hangHoa == null)
            {
                throw new Exception("Không tìm thấy hàng hóa");
            }
            if(_dbContext.HangHoaContext1512665De2s.Any(b => b.TenHangHoa == updateHangHoa.TenHangHoa && b.Id != id))
            {
                throw new Exception("Tên hàng hóa không được trung");
            }
            if (_dbContext.HangHoaContext1512665De2s.Any(b => b.MaHangHoa == updateHangHoa.MaHangHoa && b.Id != id))
            {
                throw new Exception("Mã hàng hóa không được trùng.");
            }
            hangHoa.TenHangHoa = updateHangHoa.TenHangHoa;
            hangHoa.MaHangHoa = updateHangHoa.MaHangHoa;
            hangHoa.SoLuong = updateHangHoa.SoLuong;
            hangHoa.DonViTinh = updateHangHoa.DonViTinh;
            _dbContext.SaveChanges();
            return new GetHangHoaDto1512665
            {
                Id = hangHoa.Id,
                MaHangHoa = hangHoa.MaHangHoa,
                TenHangHoa = hangHoa.TenHangHoa,
                DonViTinh = hangHoa.DonViTinh,
                SoLuong = hangHoa.SoLuong
            };

        }
        public List<GetHangHoaDto1512665> GetAllHangHoas()
        {
            var hangHoas = _dbContext.HangHoaContext1512665De2s.ToList();
            List<GetHangHoaDto1512665> result = new List<GetHangHoaDto1512665>();
            foreach(var hangHoa in hangHoas)
            {
                result.Add(new GetHangHoaDto1512665
                {
                    Id = hangHoa.Id,
                    TenHangHoa = hangHoa.TenHangHoa,
                    MaHangHoa = hangHoa.MaHangHoa,
                    DonViTinh = hangHoa.DonViTinh,
                    SoLuong = hangHoa.SoLuong
                });
            };
            return result;
           }

        public void DeleteHangHoaById(int id)
        {
            var hangHoa = _dbContext.HangHoaContext1512665De2s.FirstOrDefault(b => b.Id == id);
            if(hangHoa == null)
            {
                throw new Exception("Không tìm thấy hàng hóa");
            }
            _dbContext.HangHoaContext1512665De2s.Remove(hangHoa);
            _dbContext.SaveChanges();
        }

        public List<GetHangHoaDto1512665> GetAllHangHoasPaged(int pageSize, int pageIndex, HangHoaFilterDto filter)
        {
            var query = _dbContext.HangHoaContext1512665De2s.AsQueryable();

            // Lọc gần đúng theo tên hàng hóa
            if (!string.IsNullOrEmpty(filter.Keyword))
            {
                query = query.Where(b => b.TenHangHoa.Contains(filter.Keyword));
            }

            var totalItems = query.Count();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var pagedItems = query.Skip(pageSize * (pageIndex - 1))
                                  .Take(pageSize)
                                  .ToList();

            List<GetHangHoaDto1512665> result = new List<GetHangHoaDto1512665>();

            foreach (var hangHoa in pagedItems)
            {
                result.Add(new GetHangHoaDto1512665
                {
                    Id = hangHoa.Id,
                    MaHangHoa = hangHoa.MaHangHoa,
                    TenHangHoa = hangHoa.TenHangHoa,
                    DonViTinh = hangHoa.DonViTinh,
                    SoLuong = hangHoa.SoLuong
                });
            }

            return result;
        }

        public GetHangHoaDto1512665 GetHangHoaByID(int id)
        {
            var hangHoa = _dbContext.HangHoaContext1512665De2s.FirstOrDefault(b => b.Id == id);

            if (hangHoa == null)
            {
                throw new Exception("Không tìm thấy hàng hóa.");
            }

            return new GetHangHoaDto1512665
            {
                Id = hangHoa.Id,
                MaHangHoa = hangHoa.MaHangHoa,
                TenHangHoa = hangHoa.TenHangHoa,
                DonViTinh = hangHoa.DonViTinh,
                SoLuong = hangHoa.SoLuong
            };
        }
    }
}

using NguyenTienDung1512665.Entities;

namespace NguyenTienDung1512665.Dtos.HangHoa
{
    public class GetHangHoaDto1512665
    {
        public int Id { get; set; }
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }

        public ICollection<ItemsCertification1512665De2> ItemCertifications { get; set; }
    }
}

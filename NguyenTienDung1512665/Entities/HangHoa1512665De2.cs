namespace NguyenTienDung1512665.Entities
{
    public class HangHoa1512665De2
    {
        public int Id { get; set; }
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }

        public ICollection<ItemsCertification1512665De2> ItemCertifications { get; set; }
    }
}

namespace NguyenTienDung1512665.Entities
{
    public class Certification1512665De2
    {
        public int Id { get; set; }
        public string MaChungChi { get; set; }
        public string TenChungChi { get; set; }
        public string TenDonViCap { get; set; }

        public ICollection<ItemsCertification1512665De2> ItemCertifications { get; set; }
    }
}

namespace NguyenTienDung1512665.Entities
{
    public class ItemsCertification1512665De2
    {

        public int Id { get; set; }
        public int ItemId { get; set; }
        public int CertificationId { get; set; }

        public HangHoa1512665De2 Item { get; set; }
        public Certification1512665De2 Certification { get; set; }
    }
}

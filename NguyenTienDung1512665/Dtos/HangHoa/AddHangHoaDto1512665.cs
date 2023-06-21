namespace NguyenTienDung1512665.Dtos.HangHoa
{
    public class AddHangHoaDto1512665
    {
        public string MaHangHoa
        {
            get => _maHangHoa;
            set => _maHangHoa = value?.Trim();
        }
        public string _maHangHoa;
        public string TenHangHoa {
            get => _tenHangHoa;
            set => _tenHangHoa = value?.Trim(); 
        }
        public string _tenHangHoa;

        public string DonViTinh
        {
            get => _donViTinh;
            set => _donViTinh = value?.Trim();
        }
        public string _donViTinh;
        public int SoLuong { get; set; }
    }
}

using NguyenTienDung1512665.Dtos.HangHoa;
namespace NguyenTienDung1512665.Services.Interfaces
{
    public interface IHangHoaServices1512665De2
    {
        AddHangHoaDto1512665 AddHangHoa(AddHangHoaDto1512665 input);
        GetHangHoaDto1512665 EditHangHoaById(int id, AddHangHoaDto1512665 updateHangHoa);
        List<GetHangHoaDto1512665> GetAllHangHoas();
        void DeleteHangHoaById(int id);
        List<GetHangHoaDto1512665> GetAllHangHoasPaged(int pageSize, int pageIndex, HangHoaFilterDto filter);
        GetHangHoaDto1512665 GetHangHoaByID(int id);
    }
}

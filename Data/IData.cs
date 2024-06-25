namespace mvc;

public interface IData{

    public Task<List<Estacionamiento>> ObtenEstacionamientoAsync();
}
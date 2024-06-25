using MySqlConnector;

public class Data : IData{

    private readonly MySqlConnector _sqlConnection;

    public Data(MySqlConnector mySqlConnection){

        _sqlConnection = mySqlConnection;
    }

    public async Task<List<Estacionamiento>> ObtenEstacionamientoAsync();
}
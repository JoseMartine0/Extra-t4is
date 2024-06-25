using MySqlConnector;
using IData;

public class Data : IData{

    private readonly MySqlConnector _sqlConnection;

    public Data(MySqlConnector mySqlConnection){

        _sqlConnection = mySqlConnection;
    }

    public async Task<List<Estacionamiento>> ObtenEstacionamientoAsync(){
        
        await _sqlConnection.OpenAsync();

        List<Estacionamiento> lugares = new();
        using var command = new MySqlCommand(@"SELECT lugares.id", _sqlConnection);
        using var reader = await command.ExecuteReaderAsync();
    }
    return Estacionamiento;
}
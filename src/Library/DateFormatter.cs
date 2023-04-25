namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string Correct(string date)
{
    string fechacorrecta = string.Empty;
    int day,month ,year;
    if (date.Length == 10 && date[2] == '/' && date[5] == '/')
    {
        fechacorrecta = date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
    }
     if ( date==string.Empty)
        {
            return string.Empty;
        }

    if (int.TryParse(date.Substring(0, 2), out day) && int.TryParse(date.Substring(3, 2), out month) && int.TryParse(date.Substring(6), out year))
        {
            try
            {
                DateTime fecha = new DateTime(year, month, day);
                fechacorrecta = fecha.ToString("yyyy-MM-dd");
            }
            catch (ArgumentOutOfRangeException)
            {
                // Fecha inválida
            }
        }
    

       
        return fechacorrecta;
}

}


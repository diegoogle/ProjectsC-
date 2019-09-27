namespace List
{
  class CTelefono
  {
    private string _nombre = "Un nombre";
    private decimal _telefono = 0;

    public string Nombre
    {
      get { return _nombre; }
      set { _nombre = value; }
    }

    public decimal Telefono
    {
      get { return _telefono; }
      set { _telefono = value; }
    }
  }
}

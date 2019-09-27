
namespace ComponentesAccesoDatos
{
  class CTelefonoBLL
  {
    private CTelefonoDAL bd = new CTelefonoDAL();

    public CTelefonoBO ObtenerFilaTfnos(string tfno)
    {
      return bd.ObtenerFilaTfnos(tfno);
    }

    public ColCTelefonos ObtenerFilasTfnos()
    {
      ColCTelefonos coTfnos = bd.ObtenerFilasTfnos();
      return coTfnos;
    }

    public string InsertarFilaTfnos(CTelefonoBO bo)
    {
      return bd.InsertarFilaTfnos(bo);
    }

    public void BorrarFilaTfnos(string tfno)
    {
      bd.BorrarFilaTfnos(tfno);
    }

    public void ActualizarNomDirTfnObs(CTelefonoBO bo, string tfnoAntiguo)
    {
      bd.ActualizarNomDirTfnObs(bo, tfnoAntiguo);
    }

    public void ActualizarNomDirObs(CTelefonoBO bo)
    {
      bd.ActualizarNomDirObs(bo);
    }
  }
}

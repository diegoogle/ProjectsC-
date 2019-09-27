using System.Collections.Specialized;
using System.ComponentModel;

namespace ComponentesAccesoDatos
{
  class CTelefonoBLL
  {
    private CTelefonoDAL bd = new CTelefonoDAL();
    private string tfnoAnterior;

    public CTelefonoBO ObtenerFilaTfnos(string tfno)
    {
      return bd.ObtenerFilaTfnos(tfno);
    }

    public ColCTelefonos ObtenerFilasTfnos()
    {
      ColCTelefonos coTfnos = bd.ObtenerFilasTfnos();
      coTfnos.ListChanged +=
        new ListChangedEventHandler(ControladorListChanged);
      // Asignar un controlador para los eventos ItemBeginEdit e 
      // ItemEndEdit del objeto colección coTfnos
      coTfnos.ItemEndEdit +=
        new ItemEditEventHandler(ControladorItemEndEdit);
      coTfnos.ItemBeginEdit +=
        new ItemEditEventHandler(ControladorItemBeginEdit);
      return coTfnos;
    }

    private void ControladorListChanged(object sender, ListChangedEventArgs e)
    {
      if (e.ListChangedType == ListChangedType.ItemDeleted)
        BorrarFilaTfnos(tfnoAnterior);
      else if (e.ListChangedType == ListChangedType.ItemAdded)
      {
        if (e.OldIndex == -1)
        {
          CTelefonoBO obj = (sender as ColCTelefonos)[e.NewIndex];
          obj.Nombre = "nombre";
          obj.Direccion = "dirección";
          obj.Telefono = "000000000";
          obj.Observaciones = "Ninguna";
        }
      }
    }

    private void ControladorItemBeginEdit(IEditableObject sender)
    {
      tfnoAnterior = (sender as CTelefonoBO).Telefono;
    }

    private void ControladorItemEndEdit(IEditableObject sender)
    {
      CTelefonoBO obj = sender as CTelefonoBO;
      if (obj.Modificado == false) return;

      if (ObtenerFilaTfnos(obj.Telefono) == null)
      {
        if (tfnoAnterior != null && ObtenerFilaTfnos(tfnoAnterior) != null)
        {
          BorrarFilaTfnos(tfnoAnterior);
        }
        InsertarFilaTfnos(obj);
      }
      else
      {
        ActualizarNomDirObs(obj);
      }
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

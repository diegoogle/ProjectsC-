using System.ComponentModel;

namespace ComponentesAccesoDatos
{
  class ColCTelefonos : BindingList<CTelefonoBO>
  {
    // Eventos ItemBeginEdit e ItemEndEdit de la colección
    public event ItemEditEventHandler ItemBeginEdit;
    public event ItemEditEventHandler ItemEndEdit;

    protected override void InsertItem(int ind, CTelefonoBO item)
    {
      // Insertar un elemento en la posición especificada
      base.InsertItem(ind, item);
      // Asignar un controlador para los eventos ItemBeginEdit e
      // ItemEndEdit de cada item CTelefonoBO de la colección
      item.ItemBeginEdit +=
        new ItemEditEventHandler(ControladorItemBeginEdit);
      item.ItemEndEdit +=
        new ItemEditEventHandler(ControladorItemEndEdit);
    }

    private void ControladorItemBeginEdit(IEditableObject sender)
    {
      // Generar el evento ItemBeginEdit de la colección por cada
      // evento ItemBeginEdit generado por un item CTelefonoBO 
      if (ItemBeginEdit != null)
      {
        ItemBeginEdit(sender);
      }
    }

    private void ControladorItemEndEdit(IEditableObject sender)
    {
      // Generar el evento ItemEndEdit de la colección por cada
      // evento ItemEndEdit generado por un item CTelefonoBO 
      if (ItemEndEdit != null)
      {
        ItemEndEdit(sender);
      }
    }
  }
}

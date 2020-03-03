 public DataTable ToDataTable<T>(IList<T> data) {
            DataTable dTable = new DataTable();
            try {
                PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
                for (int i = 0; i < props.Count; i++) {
                    PropertyDescriptor prop = props[i];
                    dTable.Columns.Add(prop.Name, prop.PropertyType);
                }
                object[] values = new object[props.Count];
                foreach (T item in data) {
                    for (int i = 0; i < values.Length; i++) {
                        values[i] = props[i].GetValue(item);
                    }
                    dTable.Rows.Add(values);
                }
            } catch (Exception e) {
                throw new ApplicationException(nameClass + " <ToDataTable> " + e.Message);
            }
            return dTable;
        }

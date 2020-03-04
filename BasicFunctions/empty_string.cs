public bool emptyString(string dato) {
            try {
                if (string.IsNullOrWhiteSpace(dato)) {
                    return false;
                } else {
                    return true;
                }
            } catch (Exception e) {
                Console.WriteLine("The value: " + dato + " cant be read");
                return false;
            }
        }//return false when dato is null o empty

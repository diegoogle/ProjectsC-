private int toInt(string v) {
            int result = 0;
            try {
                int.Parse(v);
            } catch (Exception) {
            }
            return result;
        }

namespace CMP1124M_AlgorithmsAndComplexity {

    class Roads {

        String[] Road_1_256; // This is the string array that stores the contents of Road_1_256.txt
        public String[] _Road_1_256 { get { return Road_1_256; } }

        String[] Road_1_2048; // This is the string array that stores the contents of Road_1_2048.txt
        public String[] _Road_1_2048 { get { return Road_1_2048; } }

        String[] Road_2_256; // This is the string array that stores the contents of Road_2_256.txt
        public String[] _Road_2_256 { get { return Road_2_256; } }

        String[] Road_2_2048; // This is the string array that stores the contents of Road_2_2048.txt
        public String[] _Road_2_2048 { get { return Road_2_2048; } }

        String[] Road_3_256; // This is the string array that stores the contents of Road_3_256.txt
        public String[] _Road_3_256 { get { return Road_3_256; } }

        String[] Road_3_2048; // This is the string array that stores the contents of Road_3_2048.txt
        public String[] _Road_3_2048 { get { return Road_3_2048; } }

        String[] Road_256_Merged; // This is the string array that stores the contents of Road_1_256.txt and Road_3_256.txt merged
        public String[] _Road_256_Merged { get { return Road_256_Merged; } }

        String[] Road_2048_Merged; // This is the string array that stores the contents of Road_1_2048.txt and Road_3_2048.txt merged
        public String[] _Road_2048_Merged { get { return Road_2048_Merged; } }


        public Roads() { // This constructor reads the road files and stores them in the string arrays
            Road_1_256 = System.IO.File.ReadAllLines("Roads/Road_1_256.txt");
            Road_1_2048 = System.IO.File.ReadAllLines("Roads/Road_1_2048.txt");

            Road_2_256 = System.IO.File.ReadAllLines("Roads/Road_2_256.txt");
            Road_2_2048 = System.IO.File.ReadAllLines("Roads/Road_2_2048.txt");

            Road_3_256 = System.IO.File.ReadAllLines("Roads/Road_3_256.txt");
            Road_3_2048 = System.IO.File.ReadAllLines("Roads/Road_3_2048.txt");

            // Merge Road_1_256 and Road_3_256 into Road_256_Merged
            Road_256_Merged = Road_1_256.Concat(Road_3_256).ToArray();

            // Merge Road_1_2048 and Road_3_2048 into Road_2048_Merged
            Road_2048_Merged = Road_1_2048.Concat(Road_3_2048).ToArray();
        }

        public String[] DisplayNumElements(String road, bool ascending, int sortType, int numElements) { // This method returns a string array of every 10th element of the road in ascending or descending order

            String[] selectedRoad;

            if (road == "Road_1_256") { // If the road is Road_1_256
                selectedRoad = _Road_1_256;
            } else
            if (road == "Road_1_2048") { // If the road is Road_1_2048
                selectedRoad = _Road_1_2048;
            } else
            if (road == "Road_2_256") { // If the road is Road_2_256
                selectedRoad = _Road_2_256;
            } else
            if (road == "Road_2_2048") { // If the road is Road_2_2048
                selectedRoad = _Road_2_2048;
            } else
            if (road == "Road_3_256") { // If the road is Road_3_256
                selectedRoad = _Road_3_256;
            } else
            if (road == "Road_3_2048") { // If the road is Road_3_2048
                selectedRoad = _Road_3_2048;
            } else
            if (road == "Road_256_Merged") { // If the road is Road_256_Merged
                selectedRoad = _Road_256_Merged;
            } else
            if (road == "Road_2048_Merged") { // If the road is Road_2048_Merged
                selectedRoad = _Road_2048_Merged;
            } else {
                return new String[0]; // Return an empty array
            }


            List<String> returnRoad = new List<String>();
            String[] sortedRoad; // Sort the road in descending order
            
            Sort sort = new Sort(selectedRoad);
            if (sortType == 1) {
                sortedRoad = sort.BubbleSort(ascending);
            } else
            if (sortType == 2) {
                sortedRoad = sort.InsertionSort(ascending);
            } else
            if (sortType == 3) {
                sortedRoad = sort.MergeSort(ascending); // Sort the road in ascending order
            } else
            if (sortType == 4) {
                sortedRoad = sort.QuickSort(ascending);
            } else {
                return new String[0]; // Return an empty array
            }

            // Loop starts at numElements - 1 because the first element is at index 0 (e.g. 10th element is at index 9)
            for (int i = numElements - 1; i < sortedRoad.Length; i += numElements) { // Add every (numElements)th element to the returnRoad array
                returnRoad.Add(sortedRoad[i]);
            }

            returnRoad.Add("Data sorted in " + sort.Steps + " steps"); // Add the number of steps to the end of the array

            return returnRoad.ToArray(); // Return the returnRoad array
        }

        bool findElement(String[] selectedRoad, String searchValue) {

            for (int i = 0; i < selectedRoad.Length; i++) { // Loop through the road to find the value
                if (selectedRoad[i] == searchValue) {
                    return true; // Return true if the value is found
                }
            }

            return false;
        }
        
        public String[][] FindElements(String road, int searchType, String searchValue) { // This method returns the location of the value in the road

            String[] selectedRoad;

            if (road == "Road_1_256") { // If the road is Road_1_256
                selectedRoad = _Road_1_256;
            } else
            if (road == "Road_1_2048") { // If the road is Road_1_2048
                selectedRoad = _Road_1_2048;
            } else
            if (road == "Road_2_256") { // If the road is Road_2_256
                selectedRoad = _Road_2_256;
            } else
            if (road == "Road_2_2048") { // If the road is Road_2_2048
                selectedRoad = _Road_2_2048;
            } else
            if (road == "Road_3_256") { // If the road is Road_3_256
                selectedRoad = _Road_3_256;
            } else
            if (road == "Road_3_2048") { // If the road is Road_3_2048
                selectedRoad = _Road_3_2048;
            } else
            if (road == "Road_256_Merged") { // If the road is Road_256_Merged
                selectedRoad = Road_256_Merged;
            } else
            if (road == "Road_2048_Merged") { // If the road is Road_2048_Merged
                selectedRoad = Road_2048_Merged;
            } else {
                return new String[0][]; // Return an empty array
            }

            String[][] locationArray; // This is the array that will be returned
            Search search = new Search(selectedRoad);
            
            if (searchType == 1) { // If the search type is linear search
                locationArray = search.LinearSearch(searchValue);
            } else
            if (searchType == 2) { // If the search type is binary search
                locationArray = search.BinarySearch(Int32.Parse(searchValue));
            } else {
                return new String[0][]; // Return an empty array
            }

            if (locationArray.Length == 0) { // If the value is not found in the road

                return FindElementsEmpty(road, searchType, searchValue); // Find the next closest value in the road

            } else {
                List<String[]> locationList = new List<String[]>(locationArray); // Convert the array to a list
                locationList.Add(new String[2] {"SearchInfo" , "Data found in " + search.Steps + " steps" }); // Add the number of steps to the end of the array
                locationArray = locationList.ToArray(); // Convert the list to an array and return it
                
                return locationArray; // Convert the list to an array and return it
            }
        }

        String[][] FindElementsEmpty(String road, int searchType, String searchValue) { // This method returns the location of the next closest value in the road

            String[] selectedRoad;

            if (road == "Road_1_256") { // If the road is Road_1_256
                selectedRoad = _Road_1_256;
            } else
            if (road == "Road_1_2048") { // If the road is Road_1_2048
                selectedRoad = _Road_1_2048;
            } else
            if (road == "Road_2_256") { // If the road is Road_2_256
                selectedRoad = _Road_2_256;
            } else
            if (road == "Road_2_2048") { // If the road is Road_2_2048
                selectedRoad = _Road_2_2048;
            } else
            if (road == "Road_3_256") { // If the road is Road_3_256
                selectedRoad = _Road_3_256;
            } else
            if (road == "Road_3_2048") { // If the road is Road_3_2048
                selectedRoad = _Road_3_2048;
            } else
            if (road == "Road_256_Merged") { // If the road is Road_256_Merged
                selectedRoad = Road_256_Merged;
            } else
            if (road == "Road_2048_Merged") { // If the road is Road_2048_Merged
                selectedRoad = Road_2048_Merged;
            } else {
                return new String[0][]; // Return an empty array
            }

            
            bool found = false; // This is used to determine if the next closest value is found in the road
            int incrementValue = 1; // This is the value that is added to the search value to find the next closest value
            
            while (!found) {

                String newSearchValueBefore = (int.Parse(searchValue) - incrementValue).ToString(); // The next closest value
                String newSearchValueAfter = (int.Parse(searchValue) + incrementValue).ToString(); // The next closest value

                if (!findElement(selectedRoad, newSearchValueBefore) && !findElement(selectedRoad, newSearchValueAfter)) { // If the next closest value is not found in the road
                    
                    incrementValue++; // Increase the increment value

                } else { // The next closest value is found in the road

                    found = true;
                    List<String[]> locationList = new List<String[]>(); // Create a list to store the locations

                    // If the next closest value is found in the road before and after the search value
                    if (findElement(selectedRoad, newSearchValueBefore) && findElement(selectedRoad, newSearchValueAfter)) {

                        // Get the locations of the closest value before and after the search value
                        String[][] locationArrayBefore = FindElements(road, searchType, newSearchValueBefore);
                        String[][] locationArrayAfter = FindElements(road, searchType, newSearchValueAfter);

                        // Join the two arrays together
                        String[][] locationArray = new String[locationArrayBefore.Length + 1 + locationArrayAfter.Length][]; // Create a new array to store the locations
                        
                        locationArrayBefore.CopyTo(locationArray, 0); // Copy the locations after the search value to the new array
                        locationArray[locationArrayBefore.Length] = new String[2] {"", ""}; // Adds a blank line to the array
                        locationArrayAfter.CopyTo(locationArray, locationArrayBefore.Length + 1); // Copy the locations before the search value to the new array

                        return locationArray; // Return the array

                    } else
                    // If the next closest value is found in the road after the search value
                    if (findElement(selectedRoad, newSearchValueBefore)) {

                        // Get the locations of the closest value after the search value
                        return FindElements(road, searchType, newSearchValueBefore);

                    } else
                    // If the next closest value is found in the road before the search value
                    if (findElement(selectedRoad, newSearchValueAfter)) {

                        // Get the locations of the closest value before the search value
                        return FindElements(road, searchType, newSearchValueAfter);

                    }
                }
            }
            return new String[0][]; // Return an empty array (This should never happen but is needed to prevent errors)
        }
    }
}
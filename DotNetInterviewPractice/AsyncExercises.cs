namespace AsyncExercises
{
    public static class AsyncExercises
    {
        public static async Task<string> ThreeSecondWait()
        {
            await Task.Delay(3000);
            return "Operation completed after 3 seconds";
        }

        public static async Task<string> AsyncOper1()
        {
            await Task.Delay(3000);
            return "Operation 1 completed!";
        }

        public static async Task<string> AsyncOper2()
        {
            await Task.Delay(4000);
            return "Operation 2 completed!";
        }

        public static async Task<string> AsyncOper3()
        {
            await Task.Delay(2000);
            return "Operation 3 completed!";
        }

        public static async Task<string> ReadFromFileAsync(string filPath)
        {
            string result = string.Empty;
            try{
                result = await File.ReadAllTextAsync(filPath);
                return result;
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
            catch(UnauthorizedAccessException ex ){
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public static async Task<string> FetchDataAsync(string url)
        {
            string response = string.Empty;
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    HttpResponseMessage message = await client.GetAsync(url);
                    response = await message.Content.ReadAsStringAsync();
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
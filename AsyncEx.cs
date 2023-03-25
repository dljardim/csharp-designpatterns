public class AsyncEx{

    int result = 0;

    public async void Run(){

        int result = await DoSomethingAsync();
    }

    public async Task<int> DoSomethingAsync(){

        int result = 0;
        await Task.Run( () => 
        {
            result = 1;
        });

        return result;
    }
}
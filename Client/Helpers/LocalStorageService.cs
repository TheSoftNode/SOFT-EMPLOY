using Blazored.LocalStorage;

namespace Client.Helpers;

public class LocalStorageService(ILocalStorageService localStorageService)
{
	private const string StorageKey = "authentication-token";
	public async Task<string> GetToken() => await localStorageService.GetItemAsStringAsync(StorageKey);
	public async Task setToken(string item) => await localStorageService.SetItemAsStringAsync(StorageKey, item);
	public async Task RemoveToken() => await localStorageService.RemoveItemAsync(StorageKey);
}

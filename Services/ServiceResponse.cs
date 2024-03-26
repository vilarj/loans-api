namespace loans_api.Services
{
	/// <summary>
	///		The class is responsible for handling the returning response from the call.
	/// </summary>
	/// <typeparam name="T">
	///		Generic object to be used
	/// </typeparam>
	public class ServiceResponse<T>
	{
		public T? Data { get; set; }

		public bool Success { get; set; } = true;

		public string? Message { get; set; }
	}
}


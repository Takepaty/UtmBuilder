using System;

public static class ListExtensions
{
	public static void AddIfNotNull(
		this List<string> list,
		string key,
		string? value) 
	{
		if (!string.IsNullOrEmpty( value ) )
			list.Add( $"{key}={value}" );
	}
}

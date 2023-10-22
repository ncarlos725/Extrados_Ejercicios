using System;

public class SinSolucionException : Exception
{

	//Constructor
	public SinSolucionException()
	{
	}

	public SinSolucionException(string message) : base(message) 
	{
	}

	public SinSolucionException(string message, Exception inner) : base(message, inner) 
	{
	}

}

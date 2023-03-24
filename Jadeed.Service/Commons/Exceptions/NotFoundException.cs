namespace Jadeed.Service.Commons.Exceptions;

public class NotFoundException : Exception
{
	public string Point { get; set; }
	public NotFoundException(string point,string message)
		: base(message)
	{
		this.Point = point;
	}
}

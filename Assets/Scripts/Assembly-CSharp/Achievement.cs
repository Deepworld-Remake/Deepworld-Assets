using System.Collections.Generic;

public class Achievement : Configurable
{
	public Achievement(Config config, string name, Dictionary<string, object> cfg) : base(default(Config), default(string), default(Dictionary<string, object>))
	{
	}

	public string description;
	public string directions;
	public int tier;
	public string parentName;
}

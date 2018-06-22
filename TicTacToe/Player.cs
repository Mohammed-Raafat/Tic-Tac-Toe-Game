using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Player
{
    public Game Game { get; set; }
    
    public string Name { get; set; }
	public int Score { get; set; }
	public char xORo { get; set; }
	public bool Turn { get; set; }
	public bool Win { get; set; }
	public int ID { get; set; }
	
	public void Play()
	{	
	}

	public void Choose_xORo()
	{
        xORo='x';
	}
}


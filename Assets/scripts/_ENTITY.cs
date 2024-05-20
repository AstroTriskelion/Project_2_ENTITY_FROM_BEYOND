using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _ENTITY : MonoBehaviour
{
    [Header("PIANO SEQUENCE \n")]
    public string KeyInputs;
    private string Type_Input;

	[Header("CONSOLE DISPLAY FOR PIANO INPUTS \n")]
	public Text console;

	[Header("USER CAMERA FOR ENTITY TO LOOK AT \n")]
	public Transform Target;

	[Header("The ARRIVAL \n")]
    public GameObject THE_ARRIVAL;
    public GameObject AudioManager;

	//*//
	[Header("// TEMPORARY // \n")]
	public Material yellow;
    public Material blue;
    public Material white;
    private MeshRenderer meshRenderer;


    void Start()
    {
        console.text = "Digital piano online.\n";
        console.text = console.text + "Version 8.3.100. Press any key \n";
        meshRenderer = GetComponent<MeshRenderer>();

    }
	void Update()
	{
		transform.LookAt(Target);
	}

	public void AddToString(string note)
	{
        KeyInputs = KeyInputs + note;
        console.text = console.text + "The current string has " + KeyInputs + "\n";
        Conditions();
    }

    public void Conditions()
    {
        

        // DO or C//
        // MAJOR // MINOR // AUGMENTED // DIMINISHED //
        if (KeyInputs.Contains("DOMISOL") || KeyInputs.Contains("MISOLDO/8") || KeyInputs.Contains("SOLDO/8MI"))
		{
            KeyInputs = ("");
            console.text = console.text + "DO MAJOR PLAYED\n";
			POSITIVE_REACT("DO_MAJOR");
		}
        else if (KeyInputs.Contains("DORE#SOL") || KeyInputs.Contains("RE#SOLDO/8") || KeyInputs.Contains("#SOLDO/8RE"))
        {
            KeyInputs = ("");
            console.text = console.text + "DO MINOR PLAYED\n";
        }
        else if (KeyInputs.Contains("DOMISOL#") || KeyInputs.Contains("MISOL#DO/8") || KeyInputs.Contains("SOL#DO/8MI"))
        {
            KeyInputs = ("");
            console.text = console.text + "DO AUGMENTED PLAYED\n";
        }        
        else if (KeyInputs.Contains("DORE#FA#") || KeyInputs.Contains("RE#FA#DO/8") || KeyInputs.Contains("FA#DO/8RE#"))
        {
            console.text = console.text + "DO DIMINISHED PLAYED";
        }
        
        // DO# or C#//
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("DO#FASOL#") || KeyInputs.Contains("FASOL#DO#") || KeyInputs.Contains("SOL#DO#FA"))
        {
            KeyInputs = ("");
            console.text = console.text + "DO# MAJOR PLAYED";
			POSITIVE_REACT("DO#_MAJOR");
		}        
        if (KeyInputs.Contains("DO#MISOL#") || KeyInputs.Contains("MISOL#DO#") || KeyInputs.Contains("SOL#DO#MI"))
        {
            KeyInputs = ("");
            console.text = console.text +"DO# MINOR PLAYED\n";
        }       
        if (KeyInputs.Contains("DO#FALA") || KeyInputs.Contains("LADO#FA") || KeyInputs.Contains("FALADO#"))
        {
            KeyInputs = ("");
            console.text = console.text +"DO# AUGMENTED PLAYED\n";
        }      
        if (KeyInputs.Contains("DO#MISOL") || KeyInputs.Contains("MISOLDO#") || KeyInputs.Contains("SOLDO#MI"))
        {
            KeyInputs = ("");
            console.text = console.text +"DO# DIMISHED PLAYED\n";
        }
        
        // RE or D//
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("REFA#LA") || KeyInputs.Contains("FA#LARE") || KeyInputs.Contains("LAREFA#"))
        {
            KeyInputs = ("");
            console.text = console.text +"RE MAJOR PLAYED\n";
			POSITIVE_REACT("RE_MAJOR");
		}   
        else if (KeyInputs.Contains("REFALA") || KeyInputs.Contains("FALARE") || KeyInputs.Contains("LAREFA"))
        {
            KeyInputs = ("");
            console.text = console.text +"RE MINOR PLAYED\n";
        }        
        else if (KeyInputs.Contains("REFA#LA#") || KeyInputs.Contains("FA#LA#RE") || KeyInputs.Contains("LA#REFA#"))
        {
            KeyInputs = ("");
            console.text = console.text +"RE AUGMENTED PLAYED\n";
        }       
        else if (KeyInputs.Contains("REFASOL#") || KeyInputs.Contains("FASOL#RE") || KeyInputs.Contains("SOL#REFA"))
        {
            KeyInputs = ("");
            console.text = console.text +"RE DIMISHED PLAYED\n";
        }
        
        // RE# //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("RE#SOLLA#") || KeyInputs.Contains("SOLLA#RE#") || KeyInputs.Contains("LA#RE#SOL"))
        {
            KeyInputs = ("");
            console.text = console.text +"RE# MAJOR PLAYED\n";
			POSITIVE_REACT("RE#_MAJOR");
		}        
        else if (KeyInputs.Contains("RE#FA#SI#") || KeyInputs.Contains("FA#SI#RE#") || KeyInputs.Contains("SI#RE#FA#"))
        {
            KeyInputs = ("");
            console.text = console.text +"RE# MINOR PLAYED\n";
        }        
        else if (KeyInputs.Contains("RE#SOLSI") || KeyInputs.Contains("SOLSIRE#") || KeyInputs.Contains("SIRE#SOL"))
        {
            KeyInputs = ("");
            console.text = console.text +"RE# AUGMENTED PLAYED\n";
        }        
        else if (KeyInputs.Contains("RE#FA#LA") || KeyInputs.Contains("FA#LARE#") || KeyInputs.Contains("LARE#FA#"))
        {
            KeyInputs = ("");
            console.text = console.text +"RE# DIMINISHED PLAYED\n";
        }     

        // MI //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("MISOL#SI") || KeyInputs.Contains("SOL#SIMI") || KeyInputs.Contains("SIMISOL#"))
        {
            KeyInputs = ("");
            console.text = console.text +"MI MAJOR PLAYED\n";
			POSITIVE_REACT("MI_MAJOR");
		}       
        else if (KeyInputs.Contains("MISOLSI") || KeyInputs.Contains("SOLSIMI") || KeyInputs.Contains("SIMISOL"))
        {
            KeyInputs = ("");
            console.text = console.text +"MI MINOR PLAYED\n";
        }              
        else if (KeyInputs.Contains("MISOL#DO/8") || KeyInputs.Contains("SOL#DO/8MI") || KeyInputs.Contains("DO/8MISOL#") || KeyInputs.Contains("DOMISOL#") || KeyInputs.Contains("MISOL#DO"))
        {
            KeyInputs = ("");
            console.text = console.text +"MI AUGMENTED PLAYED\n";
        }               
        else if (KeyInputs.Contains("MISOLLA#") || KeyInputs.Contains("SOLLA#MI") || KeyInputs.Contains("LA#MISOL"))
        {
            KeyInputs = ("");
            console.text = console.text +"MI DIMINISHED PLAYED\n";
        }

        // FA //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("FALADO/8") || KeyInputs.Contains("LADO/8FA") || KeyInputs.Contains("DO/8FALA") || KeyInputs.Contains("DOFALA"))
        {
            KeyInputs = ("");
            console.text = console.text +"FA MAJOR PLAYED\n";
			POSITIVE_REACT("FA_MAJOR");
		}
        else if (KeyInputs.Contains("FASOL#DO/8") || KeyInputs.Contains("SOL#DO/8FA") || KeyInputs.Contains("DO/8FASOL#") || KeyInputs.Contains("DOFASOL#"))
        {
            KeyInputs = ("");
            console.text = console.text +"FA MINOR PLAYED\n";
        }
        else if (KeyInputs.Contains("FALADO#") || KeyInputs.Contains("LADO#FA") || KeyInputs.Contains("DO#FALA"))
        {
            KeyInputs = ("");
            console.text = console.text +"FA AUGMENTED PLAYED\n";
        }
        else if (KeyInputs.Contains("FASOL#SI") || KeyInputs.Contains("SOL#SIFA") || KeyInputs.Contains("SIFASOL#"))
        {
            KeyInputs = ("");
            console.text = console.text +"FA DIMINISHED PLAYED\n";
        }

        // FA# //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("FA#LA#DO#") || KeyInputs.Contains("LA#DO#FA#") || KeyInputs.Contains("DO#FA#LA#"))
        {
            KeyInputs = ("");
            console.text = console.text +"FA# MAJOR PLAYED\n";
			POSITIVE_REACT("FA#_MAJOR");
		}
        else if (KeyInputs.Contains("FA#LADO#") || KeyInputs.Contains("LADO#FA#") || KeyInputs.Contains("DO#FA#LA"))
        {
            KeyInputs = ("");
            console.text = console.text +"FA# MINOR PLAYED\n";
        }
        else if (KeyInputs.Contains("FA#LA#RE") || KeyInputs.Contains("LA#REFA#") || KeyInputs.Contains("REFA#LA#"))
        {
            KeyInputs = ("");
            console.text = console.text +"FA# AUGMENTED PLAYED\n";
        }
        else if (KeyInputs.Contains("FA#LADO/8") || KeyInputs.Contains("LADO/8FA#") || KeyInputs.Contains("DO/8FA#LA") || KeyInputs.Contains("DOFA#LA"))
        {
            KeyInputs = ("");
            console.text = console.text +"FA# DIMINISHED PLAYED\n";
        }

        // SOL //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("SOLSIRE") || KeyInputs.Contains("SIRESOL") || KeyInputs.Contains("RESOLSI"))
        {
            KeyInputs = ("");
            console.text = console.text +"SOL MAJOR PLAYED\n";
			POSITIVE_REACT("SOL_MAJOR");
		}
        else if (KeyInputs.Contains("SOLLA#RE") || KeyInputs.Contains("LA#RESOL") || KeyInputs.Contains("RESOLLA#"))
        {
            KeyInputs = ("");
            console.text = console.text +"SOL MINOR PLAYED\n";
        }
        else if (KeyInputs.Contains("SOLSIRE#") || KeyInputs.Contains("SIRE#SOL") || KeyInputs.Contains("RE#SOLSI"))
        {
            KeyInputs = ("");
            console.text = console.text +"SOL AUGMENTED PLAYED\n";
        }
        else if (KeyInputs.Contains("SOLLA#DO#") || KeyInputs.Contains("LA#DO#SOL") || KeyInputs.Contains("DO#SOLLA#"))
        {
            KeyInputs = ("");
            console.text = console.text +"SOL DIMINISHED PLAYED\n";
        }

        // SOL# //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("SOL#DO/8RE#") || KeyInputs.Contains("DO/8RE#SOL#") || KeyInputs.Contains("RE#SOL#DO/8") || KeyInputs.Contains("SOL#DORE#") || KeyInputs.Contains("DORE#SOL#") || KeyInputs.Contains("RE#SOL#DO"))
        {
            KeyInputs = ("");
            console.text = console.text +"SOL MAJOR PLAYED\n";
			POSITIVE_REACT("SOL#_MAJOR");
		}
        else if (KeyInputs.Contains("SOL#SIRE#") || KeyInputs.Contains("SIRE#SOL#") || KeyInputs.Contains("RE#SOL#SI"))
        {
            KeyInputs = ("");
            console.text = console.text +"SOL# MINOR PLAYED\n";
        }
        else if (KeyInputs.Contains("SOL#DO/8MI") || KeyInputs.Contains("DO/8MISOL#") || KeyInputs.Contains("MISOL#DO/8") || KeyInputs.Contains("SOL#DOMI") || KeyInputs.Contains("DOMISOL#") || KeyInputs.Contains("MISOL#DO"))
        {
            KeyInputs = ("");
            console.text = console.text +"SOL# AUGMENTED PLAYED\n";
        }
        else if (KeyInputs.Contains("SOL#SIRE") || KeyInputs.Contains("SIRESOL#") || KeyInputs.Contains("RESOL#SI"))
        {
            KeyInputs = ("");
            console.text = console.text +"SOL# DIMINISHED PLAYED\n";
        }

        // LA //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("LADO#MI") || KeyInputs.Contains("DO#MILA") || KeyInputs.Contains("MILADO#"))
        {
            KeyInputs = ("");
            console.text = console.text +"LA MAJOR PLAYED\n";
			POSITIVE_REACT("LA_MAJOR");
		}
        else if (KeyInputs.Contains("LADO/8MI") || KeyInputs.Contains("DO/8MILA") || KeyInputs.Contains("MILADO/8") || KeyInputs.Contains("DOMILA"))
        {
            KeyInputs = ("");
            console.text = console.text +"LA MINOR PLAYED\n";
        }
        else if (KeyInputs.Contains("LADO#FA") || KeyInputs.Contains("DO#FALA") || KeyInputs.Contains("FALADO#"))
        {
            KeyInputs = ("");
            console.text = console.text +"LA AUGMENTED PLAYED\n";
        }
        else if (KeyInputs.Contains("LADO/8RE#") || KeyInputs.Contains("DO/8RE#LA") || KeyInputs.Contains("RE#LADO/8") || KeyInputs.Contains("DORE#LA"))
        {
            KeyInputs = ("");
            console.text = console.text +"LA DIMINISHED PLAYED\n";
        }

        // LA# //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("LA#REFA") || KeyInputs.Contains("REFALA#") || KeyInputs.Contains("FALA#RE"))
        {
            KeyInputs = ("");
            console.text = console.text +"LA# MAJOR PLAYED\n";
			POSITIVE_REACT("LA#_MAJOR");
		}
        else if (KeyInputs.Contains("LA#DO#FA") || KeyInputs.Contains("DO#FALA#") || KeyInputs.Contains("FALA#DO#"))
        {
            KeyInputs = ("");
            console.text = console.text +"LA# MINOR PLAYED\n";
        }
        else if (KeyInputs.Contains("LA#REFA#") || KeyInputs.Contains("REFA#LA#") || KeyInputs.Contains("FA#LA#RE"))
        {
            KeyInputs = ("");
            console.text = console.text +"LA# AUGMENTED PLAYED\n";
        }
        else if (KeyInputs.Contains("LA#DO#MI") || KeyInputs.Contains("DO#MILA#") || KeyInputs.Contains("MILA#DO#"))
        {
            KeyInputs = ("");
            console.text = console.text +"LA# DIMINISHED PLAYED\n";
        }

        // SI //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("SIRE#FA#") || KeyInputs.Contains("RE#FA#SI") || KeyInputs.Contains("FA#SIRE#"))
        {
            KeyInputs = ("");
            console.text = console.text +"SI MAJOR PLAYED\n";
			POSITIVE_REACT("SI_MAJOR");
		}
        else if (KeyInputs.Contains("SIREFA#") || KeyInputs.Contains("REFA#SI") || KeyInputs.Contains("FA#SIRE"))
        {
            KeyInputs = ("");
            console.text = console.text +"SI MINOR PLAYED\n";
        }
        else if (KeyInputs.Contains("SIRE#SOL") || KeyInputs.Contains("RE#SOLSI") || KeyInputs.Contains("#SOLSIRE"))
        {
            console.text = console.text +"SI AUGMENTED PLAYED\n";
			KeyInputs = ("");
		}
        else if (KeyInputs.Contains("SIREFA") || KeyInputs.Contains("REFASI") || KeyInputs.Contains("FASIRE"))
        {
            console.text = console.text +"SI DIMINISHED PLAYED\n";
			THE_ULTIMATE_ONES();
		}
        
        if (KeyInputs.Length >= 9)
        {
            KeyInputs = "";
            console.text = console.text +"SEQUENCE FAILED\n";
        }
        else
        {
            console.text = console.text +"Missing a note to complete sequence\n";
		}
    }

    public void HARDRESET() 
    {
        KeyInputs = ("");
        console.text = "";
        console.text = "Sequence hard reset\n";
    }

    public IEnumerator REACT1()
    {
        meshRenderer.material = blue;
        yield return new WaitForSeconds(1);
        meshRenderer.material = white;
    }
    public IEnumerator REACT2()
    {
        meshRenderer.material = yellow;
        yield return new WaitForSeconds(1);
        meshRenderer.material = white;

    }

    public void POSITIVE_REACT(string type1)
    {
        if (type1 == Type_Input)
        {
            // play neutral
        }

        else if (type1 != Type_Input)
        {
            Type_Input = type1;
			// play happy

		}
	}

	public void OTHER_REACT(string type2)
	{
		if (type2 == "SAD")
		{
			// play sad
		}

		else if (type2 == "ANGRY")
		{
			// play angry
		}

		else if (type2 == "NEUTRAL")
		{
			// play neutral
		}
	}

	public void THE_ULTIMATE_ONES()
	{
		KeyInputs = ("");
		console.text = "";
		console.text = "*/#|§! LOCATION AQUIRED */£#| \n*/#»! RISE FROM THE DEEP */£#%%% \n »«»*?«! TERMINATION AUTORISED */£§#| \n";
        THE_ARRIVAL.SetActive(true);
        AudioManager.GetComponent<_Background_Sounds>().CutMusic();
        
	}

	public void hint()
	{
		KeyInputs = ("");
		console.text = "";
		console.text = "Emergency:\n%/ Th£ s£Qu£nC£ oF\ns@Lv@Ti0n\nHid£s be||ow th£ d£$K\n";
	}

}

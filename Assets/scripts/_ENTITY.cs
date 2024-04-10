using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _ENTITY : MonoBehaviour
{
    public string KeyInputs;
    public Text console;
    void Start()
    {
        Debug.Log("Digital piano online.");
        Debug.Log("Version 8.3.100. Press any key");
    }

    public void AddToString(string note)
	{
        KeyInputs = KeyInputs + note;
        Debug.Log("The current string has " + KeyInputs);
        Conditions();
    }

    public void Conditions()
    {
        // DO //
		if (KeyInputs.Contains("DODO"))
		{
            Debug.Log("It has no delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DORE"))
        {
            Debug.Log("It has 1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DOMI"))
        {
            Debug.Log("It has 2 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DOFA"))
        {
            Debug.Log("It has 3 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DOSOL"))
        {
            Debug.Log("It has 4 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DOLA"))
        {
            Debug.Log("It has 5 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DOSI"))
        {
            Debug.Log("It has 6 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DODO/8"))
        {
            Debug.Log("It has 7 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }

        // RE //
        if (KeyInputs.Contains("REDO"))
        {
            Debug.Log("It has -1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("RERE"))
        {
            Debug.Log("It has no delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("REMI"))
        {
            Debug.Log("It has 1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("REFA"))
        {
            Debug.Log("It has 2 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("RESOL"))
        {
            Debug.Log("It has 3 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("RELA"))
        {
            Debug.Log("It has 4 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("RESI"))
        {
            Debug.Log("It has 5 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("REDO/8"))
        {
            Debug.Log("It has 6 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }       

        // MI //
        if (KeyInputs.Contains("MIDO"))
        {
            Debug.Log("It has -2 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("MIRE"))
        {
            Debug.Log("It has -1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("MIMI"))
        {
            Debug.Log("It has no delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("MIFA"))
        {
            Debug.Log("It has 1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("MISOL"))
        {
            Debug.Log("It has 2 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("MILA"))
        {
            Debug.Log("It has 3 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("MISI"))
        {
            Debug.Log("It has 4 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("MIDO/8"))
        {
            Debug.Log("It has 5 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }       
        
        // FA //
        if (KeyInputs.Contains("FADO"))
        {
            Debug.Log("It has -3 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("FARE"))
        {
            Debug.Log("It has -2 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("FAMI"))
        {
            Debug.Log("It has -1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("FAFA"))
        {
            Debug.Log("It has no delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("FASOL"))
        {
            Debug.Log("It has 1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("FALA"))
        {
            Debug.Log("It has 2 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("FASI"))
        {
            Debug.Log("It has 3 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("FADO/8"))
        {
            Debug.Log("It has 4 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }

        // SOL //
        if (KeyInputs.Contains("SOLDO"))
        {
            Debug.Log("It has -4 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SOLRE"))
        {
            Debug.Log("It has -3 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SOLMI"))
        {
            Debug.Log("It has -2 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SOLFA"))
        {
            Debug.Log("It has -1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SOLSOL"))
        {
            Debug.Log("It has no delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SOLLA"))
        {
            Debug.Log("It has 1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SOLSI"))
        {
            Debug.Log("It has 2 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SOLDO/8"))
        {
            Debug.Log("It has 3 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }

        // LA //
        if (KeyInputs.Contains("LADO"))
        {
            Debug.Log("It has -5 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("LARE"))
        {
            Debug.Log("It has -4 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("LAMI"))
        {
            Debug.Log("It has -3 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("LAFA"))
        {
            Debug.Log("It has -2 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("LASOL"))
        {
            Debug.Log("It has -1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("LALA"))
        {
            Debug.Log("It has no delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("LASI"))
        {
            Debug.Log("It has 1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("LADO/8"))
        {
            Debug.Log("It has 2 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }

        // SI //
        if (KeyInputs.Contains("SIDO"))
        {
            Debug.Log("It has -6 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SIRE"))
        {
            Debug.Log("It has -5 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SIMI"))
        {
            Debug.Log("It has -4 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SIFA"))
        {
            Debug.Log("It has -3 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SISOL"))
        {
            Debug.Log("It has -2 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SILA"))
        {
            Debug.Log("It has -1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SISI"))
        {
            Debug.Log("It has no delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("SIDO/8"))
        {
            Debug.Log("It has 1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }

        // DO/8 //
        if (KeyInputs.Contains("DO/8DO"))
        {
            Debug.Log("It has -7 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DO/8RE"))
        {
            Debug.Log("It has -6 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DO/8MI"))
        {
            Debug.Log("It has -5 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DO/8FA"))
        {
            Debug.Log("It has -4 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DO/8SOL"))
        {
            Debug.Log("It has -3 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DO/8LA"))
        {
            Debug.Log("It has -2 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DO/8SI"))
        {
            Debug.Log("It has -1 delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }
        if (KeyInputs.Contains("DO/8DO/8"))
        {
            Debug.Log("It has no delay");
            KeyInputs = ("");
            Debug.Log("The current string has " + KeyInputs);
        }

        else
		{
            Debug.Log("Missing a note to complete sequence");
		}
    }

    public void HARDRESET() 
    {
        KeyInputs = ("");
        console.text = "";
        Debug.Log("Sequence hard reset");
    }
}

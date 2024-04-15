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
        // MAJOR
		if (KeyInputs.Contains("DOMISOL"))
		{
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("MISOLDO/8"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SOLDO/8MI"))
        {
            KeyInputs = ("");
        }
        // MINOR
        if (KeyInputs.Contains("DORE#SOL"))
        {
            KeyInputs = ("");
            Debug.Log("You played a major");
        }
        if (KeyInputs.Contains("RE#SOLDO/8"))
        {
            KeyInputs = ("");
            Debug.Log("You played a major");
        }
        if (KeyInputs.Contains("#SOLDO/8RE"))
        {
            KeyInputs = ("");
            Debug.Log("You played a major");
        }
        // AUGMENTED
        if (KeyInputs.Contains("DOMISOL#"))
        {
            KeyInputs = ("");
            Debug.Log("You played a major");
        }
        if (KeyInputs.Contains("MISOL#DO/8"))
        {
            KeyInputs = ("");
            Debug.Log("You played a major");
        }
        if (KeyInputs.Contains("SOL#DO/8MI"))
        {
            KeyInputs = ("");
            Debug.Log("You played a major");
        }
        // DIMINISHED
        if (KeyInputs.Contains("DORE#FA#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("RE#FA#DO/8"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("FA#DO/8RE#"))
        {
            KeyInputs = ("");
        }

        // DO #//
        // MAJOR
        if (KeyInputs.Contains("DO#FASOL#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("FASOL#DO#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SOL#DO#FA"))
        {
            KeyInputs = ("");
        }
        // MINOR
        if (KeyInputs.Contains("DO#MISOL#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("MISOL#DO#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SOL#DO#MI"))
        {
            KeyInputs = ("");
        }
        // AUGMENTED
        if (KeyInputs.Contains("DO#FALA"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("FALADO#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("LADO#FA"))
        {
            KeyInputs = ("");
        }
        // DIMINISHED
        if (KeyInputs.Contains("DO#MISOL"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("MISOLDO#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SOLDO#MI"))
        {
            KeyInputs = ("");
        }

        // RE //
        // MAJOR
        if (KeyInputs.Contains("REFA#LA"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("FA#LARE"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("LAREFA#"))
        {
            KeyInputs = ("");
        }
        // MINOR
        if (KeyInputs.Contains("REFALA"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("FALARE"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("LAREFA"))
        {
            KeyInputs = ("");
        }
        // AUGMENTED
        if (KeyInputs.Contains("REFA#LA#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("FA#LA#RE"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("LA#REFA#"))
        {
            KeyInputs = ("");
        }
        // DIMINISHED
        if (KeyInputs.Contains("REFASOL#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("FASOL#RE"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SOL#REFA"))
        {
            KeyInputs = ("");
        }

        // RE# //
        // MAJOR
        if (KeyInputs.Contains("RE#SOLLA#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SOLLA#RE#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("LA#RE#SOL"))
        {
            KeyInputs = ("");
        }
        // MINOR
        if (KeyInputs.Contains("RE#FA#SI#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("FA#SI#RE#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SI#RE#FA#"))
        {
            KeyInputs = ("");
        }
        // AUGMENTED
        if (KeyInputs.Contains("RE#SOLSI"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SOLSIRE#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SIRE#SOL"))
        {
            KeyInputs = ("");
        }
        // DIMINISHED
        if (KeyInputs.Contains("RE#FA#LA"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("FA#LARE#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("LARE#FA#"))
        {
            KeyInputs = ("");
        }

        // MI //
        // MAJOR
        if (KeyInputs.Contains("MISOL#SI"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SOL#SIMI"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SIMISOL#"))
        {
            KeyInputs = ("");
        }
        // MINOR
        if (KeyInputs.Contains("MISOLSI"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SOLSIMI"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SIMISOL"))
        {
            KeyInputs = ("");
        }
        // AUGMENTED
        if (KeyInputs.Contains("MISOL#DO/8"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("SOL#DO/8MI"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("DO/8MISOL#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("DOMISOL#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("MISOL#DO"))
        {
            KeyInputs = ("");
        }
        // DIMINISHED
        if (KeyInputs.Contains("RE#FA#LA"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("FA#LARE#"))
        {
            KeyInputs = ("");
        }
        if (KeyInputs.Contains("LARE#FA#"))
        {
            KeyInputs = ("");
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

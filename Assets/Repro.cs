using System.Collections;
using System.Collections.Generic;
using Edgar.GraphBasedGenerator.Grid2D;
using UnityEngine;

public class Repro : MonoBehaviour
{
    void Start()
    {
        // Make sure that the DLL is referenced
        var generator = new GraphBasedGeneratorGrid2D<int>(null);
    }

    void Update()
    {
        
    }
}

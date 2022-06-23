using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class codigoraycast : MonoBehaviour
{
    public GameObject bacana;
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform _selection;
   private void Update()
   {
       if (_selection != null )
       {
           var selectionRenderer = _selection.GetComponent<Renderer>();
           selectionRenderer.material = defaultMaterial;
           _selection = null;
       }
        
       var ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
       RaycastHit hit;
       if(Physics.Raycast(ray, out hit))
       {
           bacana = hit.collider.gameObject;
           if (bacana.CompareTag(selectableTag))
           {
              Score.score++;
              Destroy(bacana);        
           }
           if (bacana.CompareTag("muitobacana"))
           {
              SceneManager.LoadScene("Vitoria");  
           }
       }
   }
}

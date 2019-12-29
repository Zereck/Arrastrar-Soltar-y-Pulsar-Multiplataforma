﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; //Añadir el namespace para poder implementar sus interfaces

public class Gestures2DCollider : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IDragHandler, IBeginDragHandler, IEndDragHandler {

    public Text textBox;
    
    //Se ejecuta repetidamente mientras se esté arrastrando
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Camera.main.ScreenToWorldPoint(eventData.position);
        textBox.text = "Está siendo arrastrado";
    }

    //Se ejecuta cuando ha empezado a arrastrarse, antes del OnDrag
    public void OnBeginDrag(PointerEventData eventData)
    {
        textBox.text = "Va a ser arrastrado";
    }
    
    //Se ejecuta cuando se ha soltado, antes del OnDrop
    public void OnEndDrag(PointerEventData eventData)
    {
        textBox.text = "Va a ser soltado";
    }
    

    //Se ejecuta al finalizar la pulsación completa (levantar el dedo o ratón)
    public void OnPointerClick(PointerEventData eventData)
    {
        textBox.text = "Ha sido pulsado";
    }

    //Se ejecuta cuando el punto del ratón pasa por encima
    public void OnPointerEnter(PointerEventData eventData)
    {
        textBox.text = "El ratón está encima";
    }

    //Se ejecuta cuando el puntero, después de haber pasado por encima, sale de su collider
    public void OnPointerExit(PointerEventData eventData)
    {
        textBox.text = "El ratón ya NO está encima";
    }
    
}

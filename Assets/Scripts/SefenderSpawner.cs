using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SefenderSpawner : MonoBehaviour
{
    private Defender defender;
    private void OnMouseDown()
    {
        Vector2 pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(pos);
        SpawnDefender(SnaptoGrid(pos));
    }

    private void SpawnDefender(Vector2 pos)
    {
        if(FindObjectOfType<Text>().GetComponent<StarDisplayer>().HaveEnoughStars(defender.GetStarCost()))
        {
            FindObjectOfType<Text>().GetComponent<StarDisplayer>().SpendStars(defender.GetStarCost());
            Defender newDefender = Instantiate(defender, pos, Quaternion.identity) as Defender;

        }
        
    }

    private Vector2 SnaptoGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    public void SetSelectedDefender(Defender def)
    {
        defender = def;
    }
}

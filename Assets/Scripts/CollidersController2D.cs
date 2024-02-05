using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidersController2D : MonoBehaviour
{
    private SpriteRenderer _spr;
    private Sprite _currentSprite;
    private PolygonCollider2D po;
    private List<Vector2> path;
    private void Start()
    {
        _spr = GetComponent<SpriteRenderer>();
        _currentSprite = _spr.sprite;
        po = GetComponent<PolygonCollider2D>();
        path = new List<Vector2>();
    }
    private void Update()
    {
        if(_spr.sprite.name!=_currentSprite.name)
        {
            _currentSprite = _spr.sprite;

            Sprite s = _spr.sprite;
            po.pathCount = s.GetPhysicsShapeCount();
            for(int i =0;i<po.pathCount;i++)
            {
                path.Clear();
                s.GetPhysicsShape(i, path);
                po.SetPath(i, path.ToArray());
            }
        }
    }
}

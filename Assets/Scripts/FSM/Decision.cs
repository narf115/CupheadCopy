using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FSM
{

    [CreateAssetMenu(menuName = "FSM/Carnation/Decision")]
    public abstract class Decision : ScriptableObject
    {
        
        public abstract bool Decide(Controller controller);
    }
}
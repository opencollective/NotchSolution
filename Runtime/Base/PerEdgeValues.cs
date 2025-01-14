using UnityEngine;
using System;

namespace E7.NotchSolution
{
    [Serializable]
    public class PerEdgeValues<T>
    {
        [SerializeField] public T left;
        [SerializeField] public T bottom;
        [SerializeField] public T top;
        [SerializeField] public T right;
    }
}
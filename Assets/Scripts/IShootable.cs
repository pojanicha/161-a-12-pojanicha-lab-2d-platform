using UnityEngine;

public interface IShootable
{
    public GameObject Bullet { get; set; }
    public Transform shootPoint { get; set; }
    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }
    public void Shoot();

}

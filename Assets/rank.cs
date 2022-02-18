using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class rank : MonoBehaviour
{
    // Start is called before the first frame update
   
    public Text time;
    public Text orbs;
    public Text dam;
    public Text pts;
    public Text item;
    public Text rankT;

    public Text timeT;
    public Text orbsT;
    public Text damT;
    public Text ptsT;
    public Text itemT;
    public string ranking;
     int timer;
     int orbe;
     int damage;
     int puntos;
     int it;
    string rt;
    string ot;
    string pt;
    string dt;
    string itt;
    public rank(int v1, int v2, int v3, int v4, int v5)
    {
        V1 = v1;
        V2 = v2;
        V3 = v3;
        V4 = v4;
        V5 = v5;
    }

    public int V1 { get; }
    public int V2 { get; }
    public int V3 { get; }
    public int V4 { get; }
    public int V5 { get; }
   


    void Start()
    {
        rank Ranks = new rank(117, 1505, 200, 0, 35);
        
        time.text = Ranks.V1.ToString();
        orbs.text = Ranks.V2.ToString();
        pts.text = Ranks.V3.ToString();
        dam.text = Ranks.V4.ToString();
        item.text = Ranks.V5.ToString();

         timer = Ranks.V1;
         orbe = Ranks.V2;
         puntos = Ranks.V3;
         damage = Ranks.V4;
         it = Ranks.V5;
      
        rankT.text = totalRank().ToString();
        timeT.text=totaltime().ToString();
        orbsT.text= totalorb().ToString();
        ptsT.text= totalpts().ToString();
        damT.text = totalDam().ToString();
        itemT.text = totalItem().ToString();


    }
    public string totaltime()
    {
        if (timer > 500)
        {
            rt = "C";
        }
        if (timer < 400)
        {
            rt = "B";
        }
        if (timer < 300)
        {
            rt = "A";
        }
        if (timer < 200)
        {
            rt = "S";
        }
        if (timer < 100)
        {
            rt = "SS";
        }
        return rt;
    }
    public string totalorb()
    {
        if (orbe > 2000)
        {
            ot = "SS";
        }
        if (orbe < 2000)
        {
            ot = "S";
        }
        if (orbe < 1500)
        {
            ot = "A";
        }
        if (orbe < 1000)
        {
            ot = "B";
        }
        if (orbe < 500)
        {
            ot = "C";
        }
        return ot;
    }
    public string totalpts()
    {
        if (puntos > 7000)
        {
            pt = "SS";
        }
        if (puntos < 7000)
        {
            pt = "S";
        }
        if (puntos < 5000)
        {
            pt = "A";
        }
        if (puntos < 3000)
        {
            pt = "B";
        }
        if (puntos < 2000)
        {
            pt = "C";
        }
        return pt;
    }
    public string totalDam()
    {
        if (damage > 50)
        {
            dt = "C";
        }
        if (damage < 40)
        {
            dt = "B";
        }
         if (damage < 30)
        {
            dt = "A";
        }
         if (damage < 10)
        {
            dt = "S";
        }
         if(damage <5)
        {
            dt = "SS";
        }
        return dt;
    }
    public string totalItem()
    {
        if (it > 50)
        {
            itt= "C";
        }
        if (it < 40)
        {
            itt = "B";
        }
        if (it < 300)
        {
            itt = "A";
        }
        if (it < 10)
        {
            itt = "S";
        }
        if (it < 5)
        {
            itt = "SS";
        }
        return itt;
    }
    public string totalRank()
    {
        int rango = (timer + orbe + puntos + damage + it) / 5;
        Debug.Log(ranking + rango);
        if (rango>200)
        {
            ranking = "SS";
        }
        if (rango < 150)
        {
            ranking = "S";
        }
        if (rango < 100)
        {
            ranking = "A";
        }
        if (rango < 50)
        {
            ranking = "B";
        }
        if (rango < 30)
        {
            ranking = "C";
        }
        return ranking;
    }
    void Update()
    {
    

        
    }

}

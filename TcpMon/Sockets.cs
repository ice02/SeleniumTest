using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TcpMon
{
    class Sockets
    {

        //#region Event

        //public delegate void EventWhithIndex(ref int index, object obj);
        //public event EventWhithIndex OnConnectionEtablished;
        //public event EventWhithIndex OnDataArival;
        //public event EventWhithIndex OnClose;

        //#endregion

        //#region D�claration

        //public struct Client
        //{
        //    public Socket Socket;//Stock le socket
        //    public Thread Thread;//Stock le thread
        //    public int index;//Stock l'index
        //    public string Tag;//Tag pour le socket
        //}


        //private ArrayList ListeClients;//Stock la liste des Client Connect�
        //private Thread threadClient;//Thread pour client accept�
        //private Thread vigile = null;//Thread pour atendre une connection
        //private Socket socketServeur = null;//Socket serveur qui accepte la connexion
        //private TcpListener myListener = null;//Stock le socket qui �coute et accepte la connexion
        //private bool stop = false;//Arette g�n�rale
        //private int Port;//Stoque le port
        //private Queue[] reception;//Queue pour les message ressue

        //#endregion

        //#region Constructeur

        //public Sockets()
        //{
        //    ListeClients = new ArrayList(); //Cr�e la liste qui contien les info Client
        //    reception = new Queue[0];
        //}

        //#endregion

        //public void StartServer(int myPort)
        //{
        //    Port = myPort;//Enregistre le Port
        //    vigile = new Thread(new ThreadStart(ConnexionClient));//D�mare une �coute de client
        //    vigile.Start();// Lensse le thread
        //}

        //private void ConnexionClient()
        //{
        //    myListener = new TcpListener(Port); //Cr�e un Socket Listener
        //    myListener.Start();//Lence le Listener

        //    while (!stop)//Boucle qui r��coute
        //    {
        //        try//Gestion d'erreur
        //        {
        //            socketServeur = myListener.AcceptSocket();//La var socketServeur prend le Listener
        //            threadClient = new Thread(new ThreadStart(EcouteClient));//La var threadClient prend le Thread
        //            threadClient.IsBackground = true;//Option...
        //            threadClient.Priority = System.Threading.ThreadPriority.AboveNormal;//Option...

        //            if (socketServeur.Connected)//v�rifie si le socket est connect�
        //            {
        //                threadClient.Start();//lensse le threadClient
        //            }
        //        }
        //        catch//Gestion d'erreur
        //        {
        //        }
        //    }
        //}

        //private void EcouteClient() //Lenss� par le threadClient de ConnexionClient()
        //{
        //    Client myClient = new Client();//Cr�e une struct Client
        //    myClient.Thread = threadClient;//Met le le Thread dans la struct
        //    Socket mySocket = socketServeur;//Met le socket dans la var mySocket
        //    myClient.Socket = mySocket;//Met le socket dans la strcut
        //    myClient.index = ListeClients.Count;//Met l'index dans la struct

        //    ListeClients.Add(myClient);//Rajoute la struct dans la liste

        //    int index = ListeClients.Count - 1;//d�finie l'index en fonction de la position du client

        //    Queue[] tmpReception = reception;
        //    reception = new Queue[index + 1];
        //    for (int i = 0; i < reception.Length - 1; i++)
        //        reception[i] = tmpReception[i];
        //    reception[index] = new Queue();

        //    OnConnectionEtablished(ref index, this);//Informe d'une connection

        //    Client c = (Client)ListeClients[index];//charge la varible c avec le bon Socket
        //    while (c.Socket.Connected)//La fonction tourne en boucle ten que le socket est connect�
        //    {
        //        if (!c.Socket.Connected)//V�rifie si connect�
        //        {
        //            Close(index);//Si non ferme le socket
        //        }
        //        else //Si connect�
        //        {
        //            if (c.Socket.Poll(1, System.Net.Sockets.SelectMode.SelectRead))//D�termine l'�ta du socket(lecture)
        //            {
        //                if (c.Socket.Connected)//V�rifie si connect�
        //                {
        //                    byte[] buffer;//D�finie la varibale qui va recevoire le message en byte
        //                    int size = 0;//Taille du packet
        //                    //string commande;//Contien le mess finale

        //                    try//Gestion d'erreur
        //                    {
        //                        buffer = new Byte[c.Socket.Available];//Initialise le buffer
        //                        size = c.Socket.Receive(buffer);//Ressoi dans buffer et met la taille dans size
        //                    }
        //                    catch//Gestion d'erreur
        //                    {
        //                        if (!c.Socket.Connected)//V�rifie si connect�
        //                        {
        //                            Close(index);//Si non ferme le Socket
        //                        }
        //                        break;//Ferme le while
        //                    }

        //                    if (buffer != null)//Si buffer n'est pas vide
        //                    {

        //                        index = c.index;//Indique lindex
        //                        reception[index].Enqueue(buffer);//Ajoute le buffer a la Queu
        //                        OnDataArival(ref index, this);//Pr�vien l'utilisateur de l'ariv� de nouvelle donn�
        //                    }
        //                    else//Si le buffer est vide
        //                    {
        //                        if (!c.Socket.Connected)//Regarde si connecte
        //                        {
        //                            Close(index);//Si non ferme le socket
        //                        }
        //                    }
        //                }
        //                else//Si non connect�
        //                {
        //                    Close(index);//Ferme le socket
        //                }
        //            }
        //        }
        //    }
        //    Close(index);//Si while n'est plus �gale a connect� ferme le socket
        //}

        //private void Close(int index)
        //{
        //    try
        //    {
        //        Client c = (Client)ListeClients[index];//Prend le bon Client
        //        c.Socket.Shutdown(SocketShutdown.Both);//Arette le socket
        //        c.Socket.Close();//Ferme le socket
        //        c.Socket = null;//lib�re m�moire
        //        ListeClients.RemoveAt(index);//Suprime la strusture Client de la liste
        //        OnClose(ref index, this);//Informe une d�connection
        //        c.Thread.Abort();//Ferme le Thread
        //    }
        //    catch { }
        //}

        //public void Dispose()
        //{
        //    vigile.Abort();
        //    Client a;
        //    for (int i = 0; i < ListeClients.Count; i++)
        //    {
        //        a = (Client)ListeClients[i];
        //        a.Thread.Abort();
        //    }
        //}

        //public int ClientNumber()
        //{
        //    return ListeClients.Count;//Renvoi le nombre de client
        //}

        //public string GetData(int index)
        //{
        //    byte[] ReT = (byte[])reception[index].Dequeue();
        //    return System.Text.Encoding.Default.GetString(ReT);//Renvoi le plus vieux message ressue
        //}

        //public byte[] GetDataByte(int index)
        //{
        //    return (byte[])reception[index].Dequeue();
        //}

        //public void SetTag(string Value, int index)
        //{
        //    Client c = (Client)ListeClients[index];
        //    c.Tag = Value;
        //    ListeClients[index] = c;
        //}

        //public string GetTag(int index)
        //{
        //    Client c = (Client)ListeClients[index];
        //    return c.Tag;
        //}

        //public void Envoi(string text, int index)
        //{
        //    try
        //    {
        //        Client c = (Client)ListeClients[index];//Prend le bon socket pour le client
        //        int Ret = -1;
        //        while (Ret == -1)
        //        {
        //            System.Windows.Forms.Application.DoEvents();
        //            Ret = c.Socket.Send(System.Text.Encoding.Default.GetBytes(text), text.Length, SocketFlags.None);//Envoi...
        //        }
        //    }
        //    catch { }
        //}
        //public void EnvoiNoEncoding(byte[] text, int index)
        //{
        //    try
        //    {
        //        Client c = (Client)ListeClients[index];//Prend le bon socket pour le client
        //        int Ret = -1;
        //        while (Ret == -1)
        //        {
        //            System.Windows.Forms.Application.DoEvents();
        //            Ret = c.Socket.Send(text);//Envoi...
        //        }
        //    }
        //    catch { }
        //}
    }
}
using System;

namespace poo
{
    class Personne
    {
        static int id = 0;

        public string nom { get; init; }

        int _age;
        public int age { 
            get {
                return _age;
            } 
            set { 

                if (value >= 0) { 

                    _age = value;
                }
            } 
        }
        public string job { get; set; }
        int idPersonne;

        public Personne()
        {
            id++;
            this.idPersonne = id;
        }
        public Personne(string nom, int age, string job = null) : this()
        {
        
            this.nom = nom;
            this.age = age;
            this.job = job;

        }
        public string GetNom()
        {
            return nom;
        }
        public void Afficher()
        {
            Console.WriteLine($"Personne n°{idPersonne}");
            Console.WriteLine($"Nom : {nom}");
            Console.WriteLine($"Age : {age} ans");
            if(job == null)
            {
                Console.WriteLine("Aucun emploi spécifié");
            }
            else
            {
                Console.WriteLine($"Job : {job}\n");
            }

        }

        public static void AfficherNombreDePersonnes()
        {
            Console.WriteLine($"\nNombre total de personnes : {Personne.id} \n");
        }

    }
    class Program
    {
        static void ShowPersonnInfo(string nom, int age, string job)
        {
            Console.WriteLine($"Nom : {nom}");
            Console.WriteLine($"Age : {age} ans");
            Console.WriteLine($"Job : {job}");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<string> noms = new List<string> { "Paul", "Jacques", "David"};
            List<int> ages = new List<int> { 30, 35, 20 };
            List<string> jobs = new List<string> { "Développeur", "Professeur", "Etudiant" };

            for (int i = 0; i < noms.Count; i++)
            {
                ShowPersonnInfo(noms[i], ages[i], jobs[i]);
                Console.WriteLine("--------\n");
            }


            Console.WriteLine("-======================-");

            Personne personne1 = new Personne("Paul", 30, "Developpeur");
            personne1.Afficher();
            
            Personne personne2 = new Personne("Jacques", 35, "Professeur");
            personne2.Afficher();


            Console.WriteLine("---------");

            List<Personne> personnes = new List<Personne> { 
                new Personne("Paul", 30, "Développeur"), 
                new Personne("Jacques", 35, "Professeur"), 
                new Personne("David", 20, "Etudiant"),
                new Personne("Juliette", 8)};

            // personnes = personnes.OrderBy(p => p.GetNom().ToList());

            foreach (Personne personne in personnes)
            {
                personne.Afficher();
            }

            Personne.AfficherNombreDePersonnes();

            Personne personne3 = new Personne { nom = "Rick", age = 30, job = "Ingénieur"  };
            personne3.Afficher();
            personne3.age = -2;
            personne3.Afficher();

        }
    }
}
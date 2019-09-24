using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Histoir_horreur_Real
{
    class Program
    {
        static void AfficherTextAvecPause(string message)
        {
            Thread.Sleep(5000);
            Console.WriteLine(message);
            Thread.Sleep(3000);
          
        }
        static void AfficherAvecEffet(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write("{0}", message[i]);
                Thread.Sleep(50);

            }
            Console.WriteLine("");

        }



        static void Main(string[] args)
        {
            string nom = "";
            int choix = 0;
            int nb = 0;
            Random generateurNb = new Random();

            Console.WriteLine("Veuiller entrer votre nom:");
            nom = (Console.ReadLine());

            AfficherAvecEffet("-" + nom + "  Allo?... Allo tes là? Sam? Sam répond à ce téléphone! Je suis là pour t'aider.");
            AfficherTextAvecPause("-Sam  J'ai besoin de ton aide vite! Je viens de me réveiller dans une chambre étrange, il y a du sang partout, sur tout les murs je ne veux pas mourrir...");
            AfficherAvecEffet("-" + nom + "  Calme toi! je vais te sortir de là mais pour l'instant tu dois me faire confiance et faire tout ce que je te dis de faire.");
            AfficherTextAvecPause("-Sam  Oui ok.");
            AfficherAvecEffet("-" + nom + "  Parfait, pour commencer tu dois avoir ce téléphone en tout temps sur toi pour que je puisse te guider sur le bon chemin, tu vas devoir aussi m'écrire tout ce que tu vois et tout ce que tu entends si tu veux que je t'aide du mieux que je peux, le but sortire de ce batiments pour que je puisse tracer ce téléphone et ensuite t'envoiyer du secours.");
            AfficherTextAvecPause("-Sam  Comprit, en ce moment, je suis dans une chambre complètement tachée de sang sur tous les murs avec aucune fenêtre, il y a un odeur infecte qui m'empêche de respirer, aucun meuble sauf un vieux matelas délabré sur le sol et 2 portes devant moi");


                Console.WriteLine("CHOIX 1=Porte1  2=Porte2");

            bool entreeValide1 = false;

            while (!entreeValide1)
            {
                choix = Convert.ToInt32(Console.ReadLine());
                if (choix == 1)
                {

                    AfficherAvecEffet("-" + nom + "  Parfait, prends la première porte");
                    AfficherTextAvecPause("-Sam  C'est bon je suis de l'autre coté, je suis dans le noir je ne vois pas beaucoup mais il me semble être dans un long couloir, j'entends des bruits étranges devant moi!");
                    AfficherAvecEffet("-" + nom + "  Comme? Quelles sortes de bruits?");
                    AfficherTextAvecPause("-Sam  ça se rapproche!!! ");
                    AfficherAvecEffet("-" + nom + "  SAM! que ce passe t'il? que vois-tu?? ");
                    AfficherTextAvecPause("-Sam  J'ENTENDS UNE PERSONNE QUI SIFFLE SE RAPROCHER DE MOI!!!!! une femme avec un masque de lapin et une hache viens vers moi!! la porte derrière est barrée je fais quoi?");
                    AfficherAvecEffet("-" + nom + "  Sam, quelles sont tes options il doit sûrement y avoir une autre sortie que tu peux prendre.");
                    AfficherTextAvecPause("-Sam  non, la seule sortie que je vois est derrière elle");
                    AfficherTextAvecPause("-Sam  elle s'est arrêtée à 5 mètre devant moi, elle me fixe avec un sourire tordu sur les lèvres, elle rit.");
                    AfficherAvecEffet("-" + nom + "  garde ton sang froid et trouve une solution.");
                    AfficherTextAvecPause("-Sam  il n'y a aucune solution, elle me regarde de ses yeux brillants d'excitation, le bras flottant dans les airs, une hache souillé dans la main prete à m'enlever la vie d'un seul coup.");
                    entreeValide1 = true;

                    nb = (int)generateurNb.Next(1, 10);

                    if (nb <= 8)
                    {
                        AfficherTextAvecPause("-Sam  ELLE MA MANQUER! Elle ma tirer sa hache et elle m'a manquer! elle n'est plus là, elle a disparu d'un coup.");
                        AfficherAvecEffet("-" + nom + "  Dieu merci tu es en vie, vite il ne faut pas perdre de temps que vois-tu? où peux-tu aller? ");
                        AfficherTextAvecPause("-Sam  Tout droit devant moi il y a des escaliers, je monte ou je descends?");


                        Console.WriteLine("CHOIX 1=Monter 2=Descendre");
                        choix = Convert.ToInt32(Console.ReadLine());

                        if (choix == 1)
                        {
                            AfficherAvecEffet("-" + nom + "  Monte, si tu es capable d'aller sur le toit je pourrais être en mesure de géolocaliser ton téléphone et te sortir de là!");
                            AfficherTextAvecPause("-Sam  Parfait, je me dépêche.");
                            AfficherTextAvecPause("-Sam  Je suis en haut mais la porte pour le toit est barrée, il y a un code sur la serrure, je fais quoi?");
                            AfficherAvecEffet("-" + nom + "  Je crois que tu vas être obligé de trouver un autre chemain.");
                            AfficherTextAvecPause("-Sam  Attends, il y a des chiffres sur le mur, comme une sorte d'énigme.");
                            AfficherTextAvecPause("-Sam  Si 1=5, 2=25, 3=325, 4=4325 5=?");
                            AfficherAvecEffet("-" + nom + "  Je crois que j'ai trouvé, la réponse est____");

                            bool entreeValide2 = false;

                            while (!entreeValide2)
                            {
                                int input = Convert.ToInt32(Console.ReadLine());
                                if (input == 1)
                                {
                                    AfficherTextAvecPause("-Sam  1? seulment 1 chiffre?");
                                    AfficherAvecEffet("-" + nom + "  Fais moi confiance, je sais ce que je dis.");
                                    AfficherTextAvecPause("-Sam  Oui ca fonctionne! Je suis sur le toit, je fais quoi maintenant?");
                                    AfficherAvecEffet("-" + nom + "  Rien, je m'occupe de tout, j'ai trouvé ta localisation, tu es dans un batiment abandonner à Saint-Raymon 2194 rue de la joie, un hélicoptère va venir te chercher dans max 15 minute, donc tien bon tu va pouvoir retrouver ta vie normal");
                                    AfficherTextAvecPause("-Sam  Merci de m'avoir guider, merci de m'avoir sauver la vie, je te suis éternelement reconnaissant.");
                                    AfficherAvecEffet("-" + nom + "  Ne me remercie surtout pas, je travaille pour les gens qui ton enlever, je suis meme la personne qui ta kidnaper en personne, mais je n'en peux plus de ce job, j'ai donc glisser un téléphone dans ta poche avant te remettre à ces gens.");
                                    AfficherTextAvecPause("-Sam  QUOI, c'est toi le salopard!");
                                    AfficherAvecEffet("-" + nom + "  Oui.");
                                    AfficherTextAvecPause("-Sam  Bref, tu m'as sauvé la vie pareil, merci.");
                                    Console.WriteLine("");
                                    AfficherTextAvecPause("30 minute plus tard, vous apprenez qu'un jeune s'est suicidé à Saint-Raymon en sautant d'un toit, il s'appelait Sam. ");
                                    AfficherTextAvecPause("-Sam  Salut" + nom);
                                    AfficherAvecEffet("-" + nom + "  Sam?");
                                    AfficherTextAvecPause("-Sam  Non.");
                                    AfficherAvecEffet("-" + nom + "  qui es tu?");
                                    AfficherTextAvecPause("-Sam  Tu es le prochain. :)");
                                    Console.WriteLine("");
                                    AfficherTextAvecPause("FIN.");
                                    entreeValide2 = true;
                                }
                                else
                                {
                                    AfficherTextAvecPause("-Sam  le code ne marche pas, il faut essayer autre chose");
                                }

                            }

                        }


                        else
                        {
                            AfficherAvecEffet("-" + nom + "  Descends. ");
                            AfficherTextAvecPause("-Sam  ok.");
                            AfficherTextAvecPause("-Sam  Je suis en bas, C'est froid.");
                            AfficherAvecEffet("-" + nom + "  Vois-tu une sortie possible?");
                            AfficherTextAvecPause("-Sam  Non pas vraiment, je suis dans une pièce assez petite et salle, il y un cassier dans le fond de la pièce, un lit sur ma droite et rien dautre que des insectes un peu partout dans la chambre.");
                            AfficherAvecEffet("-" + nom + "  Je crois que tu va etre oubliger de retourner en haut alors. ");
                            AfficherTextAvecPause("-Sam  Non attends, je vois une porte cachée derrière le casier, je vais essayer de le bouger. ");
                            AfficherTextAvecPause("-Sam  Évidament la porte semble bloquer de l'autre côter.");

                            AfficherTextAvecPause("CHOIX  1=Défonce la porte 2=Montre en haut");
                            choix = Convert.ToInt32(Console.ReadLine());

                            if (choix == 1)
                            {
                                AfficherAvecEffet("-" + nom + "  Essaie de défoncer la porte.");
                                AfficherTextAvecPause("-Sam  Oui ok.");
                                AfficherTextAvecPause("-Sam  Je n'y arrive pas!");
                                AfficherAvecEffet("-" + nom + "  Concentre toi, prend une grande respiration et donne un coup de pied en plein centre.");
                                AfficherTextAvecPause("-Sam  Attends, j'entends le même siflement que tout à l'heure, elle descends! Je fais quoi??");

                                AfficherTextAvecPause("CHOIX  1=Défonce la porte! 2=Cache toi!");
                                choix = Convert.ToInt32(Console.ReadLine());

                                if (choix == 1)
                                {
                                    AfficherAvecEffet("-" + nom + "  Arrête de niaser et défonce moi cette puti** de porte!");
                                    AfficherTextAvecPause("-Sam  C'est bon j'ai réussi' je me suis enfuis le plus loin que j'ai pu. ");
                                    AfficherAvecEffet("-" + nom + "  Vite il ne faut pas perde de temps que voit tu?");
                                    AfficherTextAvecPause("-Sam  Il a une échelle qui déscend vers les égous à coter de moi.");
                                    AfficherAvecEffet("-" + nom + "  Oui descends, il doit avoir fortement une sortie ou du moin un moyen que je puisse te géolocaliser.");
                                    AfficherTextAvecPause("-Sam  C'est d'un noir atroce ici");
                                    AfficherAvecEffet("-" + nom + "  Reste concentré on y est presque.");
                                    AfficherTextAvecPause("-Sam j'ai sentie une chose passer à tout vitesse proche de moi!");
                                    AfficherAvecEffet("-" + nom + "  Dépeche toi et trouve une sortie!");
                                    AfficherTextAvecPause("-Sam  j'entends des bruits, pas n'importe quoi quels bruits, les bruits d'un monstre, une créature, ce n'est pas humain...");
                                    AfficherAvecEffet("-" + nom + "  SAM! Ne te laisse pas distrère et trouve moi cette sortie!");
                                    AfficherTextAvecPause("-Sam  Cette chose, je la vois, c'est yeux rouge qui on soif de sang, la seul chose qui ilumine dans cette noirceur total. ");
                                    AfficherAvecEffet("-" + nom + "  Sam cour, ne reste pas planté là!");
                                    AfficherTextAvecPause("");
                                    AfficherAvecEffet("-" + nom + "  Sam?");
                                    Console.WriteLine("");
                                    AfficherTextAvecPause("ÉCHEC");
                                    AfficherTextAvecPause("SAM EST MORT PAR UNE CRÉATURE DES NOIRCEUR.");
                                }

                                else
                                {
                                    AfficherAvecEffet("-" + nom + "  Cache toi vite!");
                                    AfficherTextAvecPause("-Sam  Dans le casier ou sous le lit? ");

                                    AfficherTextAvecPause("CHOIX  1=Casier  2=Lit");
                                    choix = Convert.ToInt32(Console.ReadLine());

                                    if (choix == 1)
                                    {
                                        AfficherAvecEffet("-" + nom + "  Cache toi dans le casier.");
                                        AfficherTextAvecPause("-Sam  Je suis dans le casier, elle est là de l'autre coté.");
                                        AfficherTextAvecPause("-Sam  Elle est fachée, son rire c'est transformé en crie de colère.");
                                        AfficherTextAvecPause("-Sam  J'entends plus rien.");
                                        AfficherTextAvecPause("-Sam  Elle rit de nouveau, elle s'approche du casier! ");
                                        AfficherAvecEffet("-" + nom + "  Sam?");
                                        Console.WriteLine("");
                                        AfficherTextAvecPause("ÉCHEC");
                                        AfficherTextAvecPause("SAM EST MORT D'UN COUP DE HACHE LORSQU'IL ESSAYAIT DE SE CACHER.");
                                    }

                                    else
                                    {
                                        AfficherAvecEffet("-" + nom + "  Vite va sous le lit.");
                                        AfficherTextAvecPause("-Sam   Je suis sous le lit, elle est là dans la pièce.");
                                        AfficherTextAvecPause("-Sam  Elle est fachée, son rire c'est transformé en crie de colère.");
                                        AfficherTextAvecPause("-Sam  J'entends plus rien.");
                                        AfficherTextAvecPause("-Sam  Elle rit de nouveau, elle s'approche du lit!");
                                        AfficherAvecEffet("-" + nom + "  Sam?");
                                        Console.WriteLine("");
                                        AfficherTextAvecPause("ÉCHEC");
                                        AfficherTextAvecPause("SAM EST MORT D'UN COUP DE HACHE LORSQU'IL ESSAYAIT DE SE CACHER.");





                                    }
                                }
                            }
                            else
                            {
                                AfficherAvecEffet("-" + nom + "  Essaie tout en haut, ça doit surement etre une meilleure option. ");
                                AfficherTextAvecPause("-Sam  Oui ok.");
                                AfficherAvecEffet("-" + nom + "  Si tu es capable d'aller sur le toit je pourrais être en mesure de géolocaliser ton téléphone et te sortir de là!");
                                AfficherTextAvecPause("-Sam  Parfait, je me dépêche.");
                                AfficherTextAvecPause("-Sam  Je suis en haut mais la porte pour le toit est barrée, il y a un code sur la serrure, je fais quoi?");
                                AfficherAvecEffet("-" + nom + "  Je crois que tu vas être obligé de trouver un autre chemain.");
                                AfficherTextAvecPause("-Sam  Attends, il y a des chiffres sur le mur, comme une sorte d'énigme.");
                                AfficherTextAvecPause("-Sam  Si 1=5, 2=25, 3=325, 4=4325 5=?");
                                AfficherAvecEffet("-" + nom + "  Je crois que j'ai trouvé, la réponse est____");

                                bool entreeValide = false;

                                while (!entreeValide)
                                {
                                    int input = Convert.ToInt32(Console.ReadLine());
                                    if (input == 1)
                                    {
                                        AfficherTextAvecPause("-Sam  1? seulment 1 chiffre?");
                                        AfficherAvecEffet("-" + nom + "  Fais moi confiance, je sais ce que je dis.");
                                        AfficherTextAvecPause("-Sam  Oui ca fonctionne! Je suis sur le toit, je fais quoi maintenant?");
                                        AfficherAvecEffet("-" + nom + "  Rien, je m'occupe de tout, j'ai trouvé ta localisation, tu es dans un batiment abandonner à Saint-Raymon 2194 rue de la joie, un hélicoptère va venir te chercher dans max 15 minute, donc tien bon tu va pouvoir retrouver ta vie normal");
                                        AfficherTextAvecPause("-Sam  Merci de m'avoir guider, merci de m'avoir sauver la vie, je te suis éternelement reconnaissant.");
                                        AfficherAvecEffet("-" + nom + "  Ne me remercie surtout pas, je travaille pour les gens qui ton enlever, je suis meme la personne qui ta kidnaper en personne, mais je n'en peux plus de ce job, j'ai donc glisser un téléphone dans ta poche avant te remettre à ces gens.");
                                        AfficherTextAvecPause("-Sam  QUOI, c'est toi le salopard!");
                                        AfficherAvecEffet("-" + nom + "  Oui.");
                                        AfficherTextAvecPause("-Sam  Bref, tu m'as sauvé la vie pareil, merci.");
                                        Console.WriteLine("");
                                        AfficherTextAvecPause("30 minute plus tard, vous apprenez qu'un jeune s'est suicidé à Saint-Raymon en sautant d'un toit, il s'appelait Sam. ");
                                        AfficherTextAvecPause("-Sam  Salut" + nom);
                                        AfficherAvecEffet("-" + nom + "  Sam?");
                                        AfficherTextAvecPause("-Sam  Non.");
                                        AfficherAvecEffet("-" + nom + "  qui es tu?");
                                        AfficherTextAvecPause("-Sam  Tu es le prochain. :)");
                                        Console.WriteLine("");
                                        AfficherTextAvecPause("FIN.");
                                        entreeValide = true;
                                    }
                                    else
                                    {
                                        AfficherTextAvecPause("-Sam  le code ne marche pas, il faut essayer autre chose");
                                    }
                                }
                            }

                        }

                    }


                    else
                    {
                        AfficherTextAvecPause("ÉCHEC, vous avez échouer votre mission de sauvé sam.");
                        AfficherTextAvecPause("Sam est mort, d'une hache en plein coeur");
                        AfficherTextAvecPause("Veuillez recommencer a nouveau.");

                    }






                }
                else
                {
                    AfficherAvecEffet("-" + nom + "  Prends la deuxième porte.");
                    AfficherTextAvecPause("-Sam  Oui ok.");
                    AfficherTextAvecPause("-Sam  WOW!! J'ai faillis mourrir, il a rien sauf le vide! Un trou géant");
                    AfficherAvecEffet("-" + nom + "  Un trou? ");
                    AfficherTextAvecPause("-Sam  Oui!!!");
                    AfficherTextAvecPause("CHOIX  1=Première porte");
                }
            }    
        }
    }
}

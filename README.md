SIO2, PPE Desktop (Client Lourd)

Application de Gestion de questionnaire
Dans le cadre de la mise en place d’une politique de qualité, BelleTable a décidé de
vous confier la réalisation d’une application métier qui sera utilisée par ses
collaborateurs.
Plus précisément, le responsable pédagogique vous demande de réaliser une application
permettant de concevoir et d’enregister des questionnaires dans une base de données
Cette application sera développée en langage C#, interface WinForm. Les données
gérées par l’application seront partagées avec une application web.
Pour ce faire vous devrez,
1. Analyser le contenu du cahier des charges
2. Proposer le schéma d’une base de données (MCD) capable d’accueillir les
données.
3. Créer cette base dans MySQL
4. Développer et tester l’application

Gestion de Questionnaire : développement ‘desktop’

Contexte
Sprint N°1
L’accès à l’application sera sécurisé par une fenêtre de Login
Une fois connecté(e), un écran principal permettra d’afficher la liste des questionnaires
(Nom du questionnaire, Thème, Nombre de questions)
Au clic droit sur la liste, 3 options : Ajouter, Editer, Supprimer
L’ecran d’edition permettra :
De saisir le Nom du questionnaire (Texte)
De choisir le thème dans une liste déroulante (Développement, réseau, culture générale)
De visualiser la liste des questions dans une DataGridView (N°de la question, Question)
Au clic droit sur la liste, 3 options : Ajouter, Editer, Supprimer

Structure d’une question
Libellé (ex : 192.1024.3.3 est elle une adresse IP Valide ?)
Type de Réponse (Vrai/Faux, Liste de valeurs)

Dans le cas où la réponse est de type ‘Liste de Valeurs’, vous devrez permettre
l’enregistrement de celles-ci.
Logique Métier
Vous réaliserez des classses métier en rapport avec les tables de votre base de données
Logique de développement
Vous concevrez votre application en suivant les principes du Modèle, Vue,
Contrôleur (MVC)

Sprint N°2 (Web)
La base de données est maintenant alimentée par les questionnaires enregistrés via
l’application Desktop (Client lourd).
Avec les mêmes identifiants que dans l’application ‘Client lourd’, développez une application
Web permettant de :
.Lister les questionnaires présents
. Ouvrir un Questionnaire en parcourir son contenu (Sans Modification)
Sprint N°3 (Web & Desktop)
Dans l’application Desktop, vous ajouterez un poids à chaque réponse.
Le poids peut être positif (il rapporte des points), neutre (Il ne rapporte rien) ou négatif (il
enlève de points).
Vous ferez en sorte que ce poids soit également consultable dans l’application Web.

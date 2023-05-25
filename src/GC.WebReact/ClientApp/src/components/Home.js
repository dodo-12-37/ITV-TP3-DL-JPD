import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div>
                <h1>Bonjour ITV !</h1>
                <p>
                    Cette application web est le projet de base pour le développement d'une nouvelle interface utilisateur pour la gestion de la clientèle.
                </p>
                <p>
                    Ce projet n'est pas complet mais permet de démontrer à l'équipe de développement que tout est en place afin de débuter le développement.
                </p>
                <p>
                    Le projet utilise les technologies :
                </p>
                <ul>
                    <li><a href='https://get.asp.net/'>ASP.NET Core</a> et <a href='https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx'>C#</a> pour le code multi-platformes côté serveur</li>
                    <li><a href='https://facebook.github.io/react/'>React</a> pour le code client</li>
                    <li><a href='http://getbootstrap.com/'>Bootstrap</a> pour le CSS</li>
                </ul>
                <p>Ce qu'il faut faire fonctionner se situe dans le lien "Clients". En cliquant sur le bouton de génération de clients, l'application va essayer d'insérer des données dans la base de données.</p>
            </div>
        );
    }
}

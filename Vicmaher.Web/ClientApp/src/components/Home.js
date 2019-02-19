import React, { Component, Fragment } from 'react';
import request from "superagent";
import './Home.css';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);

        // Sets up our initial state
        this.state = {
            error: false,
            hasMore: true,
            isLoading: false,
            pageNumber: 1,
            pageLenght: 10,
            jokes: [],
        };

        // Binds our scroll event handler
        window.onscroll = () => {
            const {
                loadJokes,
                state: {
                    error,
                    isLoading,
                    hasMore,
                    pageNumber,
                    pageLenght
                },
            } = this;

            // if there's an error
            // it's already loading
            // there's nothing left to load
            if (error || isLoading || !hasMore) return;

            // Checks that the page has scrolled to the bottom
            if (window.innerHeight + document.documentElement.scrollTop >= document.documentElement.offsetHeight - 20) {
                loadJokes(pageNumber, pageLenght);
            }
        };
    }

    componentWillMount() {
        // Loads initial jokes
        this.loadJokes(this.state.pageNumber, this.state.pageLenght);
    }

    loadJokes = (pageNumber, pageLenght) => {
        this.setState({ isLoading: true }, () => {
            request
                .get('https://localhost:5001/api/data/getJokes/' + pageNumber + '/' + pageLenght)
                .then((results) => {
                    let values = results.body;
                    const nextJokes = values.data.map(joke => ({
                        id: joke.id,
                        title: joke.title,
                        description: joke.description
                    }));

                    // Merge the next jokes into our existing jokes list
                    this.setState({
                        hasMore: (this.state.jokes.length < 100),
                        isLoading: false,
                        pageNumber: pageNumber + 1,
                        pageLenght: pageLenght,
                        jokes: [
                            ...this.state.jokes,
                            ...nextJokes,
                        ],
                    });
                })
                .catch((err) => {
                    this.setState({
                        error: err.message,
                        isLoading: false,
                    });
                })
        });
    }

    render() {
        const {
            error,
            hasMore,
            isLoading,
            jokes,
        } = this.state;

        return (
            <div>
                <h1>Vicmaher</h1>
                <div id="multi_column">
                    {jokes.map(joke => (
                        <Fragment key={joke.id}>
                            <div>
                                <h3>
                                    {joke.title}
                                </h3>
                                <p>{joke.description}</p>
                            </div>
                        </Fragment>
                    ))}
                    {error &&
                        <div style={{ color: '#900' }}>
                            {error}
                        </div>
                    }
                    {isLoading &&
                        <div>Nalaganje...</div>
                    }
                    {!hasMore &&
                        <div>Trenutno ni drugih vicev na to temo.</div>
                    }
                </div>
            </div>
        );
    }
}

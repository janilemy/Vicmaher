import React, { Component, Fragment } from 'react';
import request from "superagent";

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);

        // Sets up our initial state
        this.state = {
            error: false,
            hasMore: true,
            isLoading: false,
            jokes: [],
        };

        // Binds our scroll event handler
        window.onscroll = () => {
            const {
                loadJokes,
                state: {
                    error,
                    isLoading,
                    hasMore
                },
            } = this;

            // if there's an error
            // it's already loading
            // there's nothing left to load
            if (error || isLoading || !hasMore) return;

            // Checks that the page has scrolled to the bottom
            if (window.innerHeight + document.documentElement.scrollTop === document.documentElement.offsetHeight) {
                loadJokes();
            }
        };
    }

    componentWillMount() {
        // Loads initial jokes
        this.loadJokes();
    }

    loadJokes = () => {
        this.setState({ isLoading: true }, () => {
            request
                .get('https://localhost:5001/api/data/getJokes')
                .then((results) => {
                    const nextJokes = results.body.map(joke => ({
                        id: joke.id,
                        title: joke.title,
                        description: joke.description
                    }));

                    // Merge the next jokes into our existing jokes list
                    this.setState({
                        hasMore: (this.state.jokes.length < 100),
                        isLoading: false,
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
                {jokes.map(joke => (
                    <Fragment key={joke.id}>
                        <hr />
                        <div style={{ display: 'flex' }}>
                            <div>
                                <h3 style={{ marginTop: 0 }}>
                                    @{joke.title}
                                </h3>
                                <p>{joke.description}</p>
                            </div>
                        </div>
                        <hr />
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
        );
    }
}

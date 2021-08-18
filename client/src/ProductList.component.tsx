import React from 'react';
import config from './config.json';


interface Product {
    Name: string,
    ImgUri: string,
    Price: number,
    Description: string
}
interface State {
    isLoaded: boolean;
    error: any;
    items: Array<Product>;
}

export class ProductList extends React.Component {
    // products = [
    //     {
    //         Name: "iPhone",
    //         ImgSrc: "http://localhost:5000/files/aVBob25lIDExIDEyOEdC.jpg",
    //         Price: 12999,
    //         Description: "Mobilní telefon - 6,4\" AMOLED 2400 × 1080, procesor MediaTek MT6769T 8jádrový, RAM 4 GB, interní paměť 128 GB, Micro SD až 1024 GB"
    //     },
    //     {
    //         Name: "iPhone",
    //         ImgSrc: "http://localhost:5000/files/aVBob25lIDExIDEyOEdC.jpg",
    //         Price: 12999,
    //         Description: ""
    //     },
    //     {
    //         Name: "iPhone",
    //         ImgSrc: "http://localhost:5000/files/aVBob25lIDExIDEyOEdC.jpg",
    //         Price: 12999,
    //         Description: "Mobilní telefon - 6,4\" AMOLED 2400 × 1080, procesor MediaTek MT6769T 8jádrový, RAM 4 GB, interní paměť 128 GB, Micro SD až 1024 GB"
    //     },
    //     {
    //         Name: "iPhone",
    //         ImgSrc: "http://localhost:5000/files/aVBob25lIDExIDEyOEdC.jpg",
    //         Price: 12999,
    //         Description: ""
    //     },
    //     {
    //         Name: "iPhone",
    //         ImgSrc: "http://localhost:5000/files/aVBob25lIDExIDEyOEdC.jpg",
    //         Price: 12999,
    //         Description: "Mobilní telefon - 6,4\" AMOLED 2400 × 1080, procesor MediaTek MT6769T 8jádrový, RAM 4 GB, interní paměť 128 GB, Micro SD až 1024 GB"
    //     }
    // ];
    state: Readonly<State>;

    constructor(props: any){
        super(props);
        this.state = {
            error: null,
            isLoaded: false,
            items: []
        };
    }

    render() {
        const { error, isLoaded, items } = this.state;
        if (error) {
            return <div>There is a problem with loading products</div>
        }
        else if (!isLoaded) {
            return <div>Loading...</div>
        }
        else {
            return (
                <div className="ui three column grid">
                    { this.getProductComponents(items) }
                </div>
            );
        }
    }
    getProductComponents(products: Array<Product>) : JSX.Element[] {
        return products.map(p => (
            <div className="column">
                <div className="ui segment">
                <img src={p.ImgUri} alt={p.Name}/>
                    <p><strong>{p.Name}</strong></p>
                    <p>{p.Description}</p>
                    <p><strong>{p.Price}</strong></p>
                </div>
            </div>
        ));
    }

    componentDidMount() {
        const url = config.api_base_uri + "/api/products";
        fetch(url)
        .then(res => res.json())
        .then((result)=>{
            this.setState({
                isLoaded: true,
                items: result.items
            });
        },
        (error) => {
            this.setState({
                isLoaded: true,
                error
            });
        });
    }
}

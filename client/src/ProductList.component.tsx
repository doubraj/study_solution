import React from 'react';
import config from './config.json';


interface Product {
    id: string,
    name: string,
    imgUri: string,
    price: number,
    description: string
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
            <div className="column" key={p.id}>
                <div className="ui segment">
                <img src={this.getFullImageUri(p.imgUri)} alt={p.name}/>
                    <p><strong>{p.name}</strong></p>
                    <p>{p.description}</p>
                    <p><strong>{p.price}</strong></p>
                </div>
            </div>
        ));
    }
    getFullImageUri(imgName: string) {
        return config.api_base_uri + '/files/' + imgName;
    }

    componentDidMount() {
        const url = config.api_base_uri + "/api/products";
        fetch(url)
        .then(res => res.json())
        .then((result)=>{
            this.setState({
                isLoaded: true,
                items: result
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

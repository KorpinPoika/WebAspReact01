import React from 'react';
import ReactDOM from 'react-dom/client';
import Equipments from "./equipments_combo";


function BtnHandler() {
    const root = ReactDOM.createRoot(
        document.getElementById('ts-example') as HTMLElement
    );
    root.render(
        <Equipments />
    );
}

export default BtnHandler;


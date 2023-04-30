const path = require('path');
//const CheckerPlugin = require('awesome-typescript-loader').CheckerPlugin;
const CleanWebpackPlugin = require('clean-webpack-plugin');
//const HtmlWebpackPlugin = require('html-webpack-plugin');

var APP_DIR = path.resolve(__dirname, './ClientApp');

module.exports = (env) => {
    const isDevBuild = !(env && env.prod);

    const outputDir = (env && env.publishDir)
        ? env.publishDir
        : __dirname;

    return [{
        mode: isDevBuild ? 'development' : 'production',

        devtool: 'inline-source-map',

        stats: { modules: false },

        entry: {
            'App': './ClientApp/App.tsx',
        },

        watchOptions: {
            ignored: /node_modules/
        },

        output: {
            filename: "dist/[name].bundle.js",
            path: path.join(outputDir, 'wwwroot'),
            publicPath: '/'
        },

        resolve: {
            // Add '.ts' and '.tsx' as resolvable extensions.
            extensions: [".ts", ".tsx", ".js", ".json"]
        },

        module: {
            rules: [
                // All files with a '.ts' or '.tsx' extension will be handled by 'awesome-typescript-loader'.
                {
                    test: /\.tsx?$/,
                    include: APP_DIR,
                    use: 'ts-loader'                    
                }
            ]
        },
        plugins: [
            new CleanWebpackPlugin(path.join(outputDir, 'wwwroot', 'dist')),
        //    new HtmlWebpackPlugin({
        //        inject: false,
        //        template: 'Views/Shared/_Layout.Template.cshtml',
        //        filename: '../../Views/Shared/_Layout.cshtml'
        //    })
        ]
    }];
};